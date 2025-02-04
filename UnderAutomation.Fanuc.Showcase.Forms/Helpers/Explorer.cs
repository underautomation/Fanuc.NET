using System.Diagnostics;


public static class Explorer
{
    public static void RevealFile(string path)
    {
        Process.Start("explorer.exe", $"/select,\"{path}\"");
    }
    public static void OpenDirectory(string path)
    {
        Process.Start("explorer.exe", path);
    }
}
