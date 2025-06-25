namespace InterfacesTask;

public class Smartphone : IToFilePathPrinter
{
    private string _filePath;
    private string _fileName;
    private FileFormats _fileFormat;

    private string FilePath
    {
        get
        {
            return _filePath;
        }
        set
        {
            if (!value.Trim().StartsWith('/'))
            {
                throw new ArgumentException("Invalid path: it must start with / symbol");
            }
            
            _filePath = value;
        }
    }

    private string FileName
    {
        get
        {
            return _fileName;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Trim().Any(char.IsWhiteSpace))
            {
                throw new ArgumentException("Invalid file name: it can not contain whitespaces or be empty");
            }

            _fileName = value;
        }
    }
    
    public Smartphone()
    {
        FileName = "PrintFile";
        FilePath = "/home/kirill/";
        _fileFormat = FileFormats.txt;
    }
    
    public void PrintMessage(string message)
    {
        //Print message to file logic
        Console.WriteLine($"(Smartphone) Message \"{message}\" was written to {FilePath}{FileName}.{_fileFormat.ToString()}");
    }

    public void SetFilePath(string patch)
    {
        FilePath = patch;
    }

    public void SetFileName(string name)
    {
        FileName = name;
    }

    public void SetFileFormat(FileFormats format)
    {
        _fileFormat = format;
    }
}