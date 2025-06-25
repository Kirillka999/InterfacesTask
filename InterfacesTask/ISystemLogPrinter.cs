namespace InterfacesTask;

public interface ISystemLogPrinter : IMessagePrinter
{
    public string GetSystemLog();
    public void AddLogEntry(string logMessage);
}