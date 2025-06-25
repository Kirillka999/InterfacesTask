using System.Text;

namespace InterfacesTask;

public class SmartTV : ISystemLogPrinter
{
    private List<string> _systemLog;
    
    public SmartTV()
    {
        _systemLog = new List<string>();
    }
    
    public void PrintMessage(string message)
    {
        AddLogEntry(message);
        Console.WriteLine($"(SmartTV) Message {message} was added to log");
    }

    public string GetSystemLog()
    {
        var sb = new StringBuilder();
        foreach (var se in _systemLog)
        {
            sb.AppendLine(se);
        }

        return sb.ToString();
    }

    public void AddLogEntry(string logMessage)
    {
        if (!string.IsNullOrWhiteSpace(logMessage))
        {
            _systemLog.Add(logMessage);
        }
        else
        {
            throw new ArgumentException("Can not add empty log entry");
        }
    }
}