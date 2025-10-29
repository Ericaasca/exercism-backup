static class LogLine
{
    public static string Message(string logLine)
    {
        var separatedLine = logLine.Split("]");
        string resultMessage = separatedLine[1].Replace(":", " ");
        resultMessage = resultMessage.Trim();
        return resultMessage;
    }

    public static string LogLevel(string logLine)
    {
        if (logLine.Contains("[INFO]"))
        {
            return "info";
        }
        if (logLine.Contains("[WARNING]"))
        {
            return "warning";
        }
        if (logLine.Contains("[ERROR]"))
        {
            return "error";
        }
        return "";
    }

    public static string Reformat(string logLine) => $"{Message(logLine)} ({LogLevel(logLine)})";
}