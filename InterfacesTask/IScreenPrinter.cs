namespace InterfacesTask;

public interface IScreenPrinter : IMessagePrinter
{
    public void SetScreenSize(int size);
    public void SetPixelDensity(int ppi);
}