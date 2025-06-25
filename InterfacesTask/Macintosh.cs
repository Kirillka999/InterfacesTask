namespace InterfacesTask;

public class Macintosh : IScreenPrinter
{
    private double _screenSize;
    private int _ppi;
    private double ScreenSize
    {
        get
        {
            return _screenSize;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Can not set screen size to 0 or less");
            }

            _screenSize = value;
        }
    }

    private int PPI
    {
        get
        {
            return _ppi;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Can not set screen ppi to 0 or less");
            }

            _ppi = value;
        }
    }

    public Macintosh()
    {
        ScreenSize = 16;
        PPI = 226;
    }

    public void PrintMessage(string message)
    {
        if (ScreenSize >= 0.5 && PPI >= 100)
        {
            // Print to Macintosh screen logic
            Console.WriteLine($"(Mac) Message {message} appeared on Macintosh.");
        }
        else
        {
            throw new InvalidOperationException("Can not show text: screen is too small or PPI is too low");
        }
    }

    public void SetScreenSize(int size)
    {
        ScreenSize = size;
    }

    public void SetPixelDensity(int ppi)
    {
        PPI = ppi;
    }
}