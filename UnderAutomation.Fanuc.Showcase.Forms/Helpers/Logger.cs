public static class Logger
{
    /// <summary>
    /// Add logs to Log directory
    /// </summary>
    public static void Log(string title, string value, string suffix = ".txt")
    {
        try
        {
            var logDirectory = Path.Combine(Path.GetDirectoryName(Environment.ProcessPath), "Logs");
            if (!Directory.Exists(logDirectory))
            {
                Directory.CreateDirectory(logDirectory);
            }

            var fileName = $"{DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss-ffff")} {Environment.TickCount.ToString("0000000000")} {title}{suffix}";

            File.WriteAllText(Path.Combine(logDirectory, fileName), value, System.Text.Encoding.ASCII);
        }
        catch
        { }
    }

}
