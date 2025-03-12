using UnderAutomation.Fanuc.Showcase.Forms.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

/// <summary>
/// EventArgs for the ItemRenamed event, carrying old and new names.
/// </summary>
public class ItemRenamedEventArgs : EventArgs
{
    public string OldName { get; }
    public string NewName { get; }

    public ItemRenamedEventArgs(string oldName, string newName)
    {
        OldName = oldName;
        NewName = newName;
    }
}

/// <summary>
/// EventArgs for the ItemSelected event, carrying the name of the selected item.
/// </summary>
public class ItemSelectedEventArgs : EventArgs
{
    public string SelectedItem { get; }

    public ItemSelectedEventArgs(string selectedItem)
    {
        SelectedItem = selectedItem;
    }
}

/// <summary>
/// Custom TreeView (TpTreeView) that supports:
/// 1) Updating items without losing scroll or selection,
/// 2) Highlighting multiple states (running, paused, etc.) with bold text and a fixed icon,
/// 3) Events for item renamed and item selected.
/// </summary>
public class TpTreeView : TreeView
{
    // Public events
    public event EventHandler<ItemRenamedEventArgs> ItemRenamed;
    public event EventHandler<ItemSelectedEventArgs> ItemSelected;

    // Mémorise le statut de chaque item
    private readonly Dictionary<string, UnderAutomation.Fanuc.Common.TaskStatus> _itemStatuses =
        new Dictionary<string, UnderAutomation.Fanuc.Common.TaskStatus>(StringComparer.OrdinalIgnoreCase);

    // ImageList contenant les icônes
    private readonly ImageList _imageList;

    public TpTreeView()
    {
        // Allow label editing
        this.LabelEdit = true;

        // Subscribe to label-edit event for renaming
        this.AfterLabelEdit += TpTreeView_AfterLabelEdit;

        // Subscribe to AfterSelect event to raise ItemSelected
        this.AfterSelect += TpTreeView_AfterSelect;

        // Prépare l'ImageList
        _imageList = new ImageList();
        _imageList.Images.Add(new Bitmap(1, 1));     // Index 0 : vide
        _imageList.Images.Add(Resources.running_0); // Index 1 : Running
        _imageList.Images.Add(Resources.pause);     // Index 2 : Paused
        // Ajoutez éventuellement une icône pour Aborted, par exemple :
        // _imageList.Images.Add(Resources.aborted); // Index 3 : Aborted

        // Associe l’ImageList au TreeView
        this.ImageList = _imageList;
    }

    /// <summary>
    /// Sets the list of items in the TreeView without losing scroll or selection.
    /// </summary>
    public void SetItems(string[] items)
    {
        // Remember the currently selected node (if any)
        TreeNode selectedNode = this.SelectedNode;
        string selectedText = (selectedNode != null) ? selectedNode.Text : null;

        // Remember the node that is currently at the top of the visible area
        TreeNode topNode = this.TopNode;

        // Build a dictionary of existing nodes by their text
        var existingNodesMap = new Dictionary<string, TreeNode>(StringComparer.OrdinalIgnoreCase);
        foreach (TreeNode node in this.Nodes)
        {
            existingNodesMap[node.Text] = node;
        }

        // Add or update nodes for the provided items
        foreach (var item in items)
        {
            if (!existingNodesMap.TryGetValue(item, out TreeNode existingNode))
            {
                // If there's no existing node for this item, create a new one
                var newNode = new TreeNode(item);
                this.Nodes.Add(newNode);
            }
            else
            {
                // If the node exists, remove it from the dictionary to mark it as still valid
                existingNodesMap.Remove(item);
            }
        }

        // The remaining entries in existingNodesMap are no longer in the items => remove them
        foreach (var kvp in existingNodesMap)
        {
            this.Nodes.Remove(kvp.Value);
        }

        // Try to restore the previously selected node
        if (selectedText != null)
        {
            var nodeToReselect = FindNodeByText(selectedText);
            if (nodeToReselect != null)
            {
                this.SelectedNode = nodeToReselect;
            }
        }

        // Restore the top node if it still exists
        if (topNode != null && this.Nodes.Contains(topNode))
        {
            this.TopNode = topNode;
        }
    }

    /// <summary>
    /// Définit le statut d’un seul programme (item) à la fois.
    /// Exemple : SetProgramState("ProgrammeA", TaskStatus.Running);
    /// </summary>
    public void SetProgramState(string name, UnderAutomation.Fanuc.Common.TaskStatus status)
    {
        // Mémorise le statut
        _itemStatuses[name] = status;

        // Trouve le noeud correspondant
        var node = FindNodeByText(name);
        if (node == null)
            return;

        // On remet le style "normal" avant de réappliquer un style spécifique

        switch (status)
        {
            case UnderAutomation.Fanuc.Common.TaskStatus.Running:
                node.NodeFont = new Font(this.Font, FontStyle.Bold);
                node.ImageIndex = 1;        // Running
                node.SelectedImageIndex = 1;
                break;

            case UnderAutomation.Fanuc.Common.TaskStatus.Paused:
                node.NodeFont = new Font(this.Font, FontStyle.Bold);
                node.ImageIndex = 2;        // Paused
                node.SelectedImageIndex = 2;
                break;
            default:
                node.NodeFont = null;
                node.ImageIndex = 0;
                node.SelectedImageIndex = 0;
                // Pas de style particulier
                break;
        }
    }

    /// <summary>
    /// Handler for label editing completion (renaming). Raises ItemRenamed.
    /// </summary>
    private void TpTreeView_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
    {
        // If e.Label is null or whitespace, user canceled or typed empty => cancel
        if (string.IsNullOrWhiteSpace(e.Label))
        {
            e.CancelEdit = true;
            return;
        }

        // Raise ItemRenamed event
        string oldName = e.Node.Text;
        string newName = e.Label;
        ItemRenamed?.Invoke(this, new ItemRenamedEventArgs(oldName, newName));
    }

    /// <summary>
    /// Handler for node selection changes. Raises ItemSelected.
    /// </summary>
    private void TpTreeView_AfterSelect(object sender, TreeViewEventArgs e)
    {
        if (e.Node != null)
        {
            ItemSelected?.Invoke(this, new ItemSelectedEventArgs(e.Node.Text));
        }
    }

    /// <summary>
    /// Finds a node by its text in the top-level nodes. Adapt as needed for deeper hierarchies.
    /// </summary>
    private TreeNode FindNodeByText(string text)
    {
        foreach (TreeNode node in this.Nodes)
        {
            if (string.Equals(node.Text, text, StringComparison.OrdinalIgnoreCase))
            {
                return node;
            }
        }
        return null;
    }
}
