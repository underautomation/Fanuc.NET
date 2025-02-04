using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

public static class ScreenshotsGenerator
{
    public static void Generate(MainForm frm)
    {
        var dir = new DirectoryInfo(Path.Combine(Path.GetDirectoryName(typeof(ScreenshotsGenerator).Assembly.Location), "WinformsScreenshots"));

        if (dir.Exists) dir.Delete(true);
        dir.Create();

        foreach (TreeNode node in frm.leftTreeView.Nodes)
        {
            frm.leftTreeView.SelectedNode = node;
            frm.SelectNode(node);

            var bm = new Bitmap(frm.Width, frm.Height);
            frm.DrawToBitmap(bm, new Rectangle(0, 0, bm.Width, bm.Height));
            bm.Save(Path.Combine(dir.FullName, node.Tag.GetType().Name.Split(new[] { "Control" }, StringSplitOptions.RemoveEmptyEntries)[0] + ".jpg"), ImageFormat.Jpeg);
        }

        Explorer.OpenDirectory(dir.FullName);
    }
}

