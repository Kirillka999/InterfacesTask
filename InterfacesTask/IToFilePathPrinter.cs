namespace InterfacesTask;

public interface IToFilePathPrinter : IMessagePrinter
{
    public void SetFilePath(string patch);
    public void SetFileName(string name);
    public void SetFileFormat(FileFormats format);
}