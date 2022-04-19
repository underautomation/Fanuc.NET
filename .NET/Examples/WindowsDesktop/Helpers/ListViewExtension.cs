using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public static class ListViewExtension
{

    /// <summary>
    /// Update list view
    /// </summary>
    /// <param name="list">ListView to update</param>
    /// <param name="values">Items to add to the list</param>
    /// <param name="decoders">Lambda that transforms item to column string value</param>
    public static void UpdateList<T>(this ListView list, IEnumerable<T> values, params Func<T, object>[] decoders)
    {
        try
        {
            list.BeginUpdate();

            for (int i = 0; i < values.Count(); i++)
            {
                var variable = values.ElementAt(i);

                if (i < list.Items.Count)
                {
                    // Replace item
                    for (int c = 0; c < decoders.Length; c++) list.Items[i].SubItems[c].Text = decoders[c](variable)?.ToString();
                }
                else
                {
                    // add new items
                    list.Items.Add(new ListViewItem(decoders.Select(decoder => decoder(variable)?.ToString()).ToArray()));
                }
            }

            var itemCount = list.Items.Count;
            for (int i = values.Count(); i < itemCount; i++)
            {
                // remove last items
                list.Items.RemoveAt(list.Items.Count - 1);
            }
        }
        finally
        {
            list.EndUpdate();
        }
    }

}