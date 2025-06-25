using System.Security.Principal;

namespace InterfacesTask;

class Program
{
    static void Main(string[] args)
    {
        List<IMessagePrinter> devices = new List<IMessagePrinter>
        {
            new Macintosh(),
            new Smartphone(),
            new SmartTV(),
            new SmartWatch()
        };

        foreach (var messagePrinter in devices)
        {
            messagePrinter.PrintMessage("Hello world!");
        }
    }
}