namespace InterfacesTask;

public interface IAudioPrinter : IMessagePrinter
{
    public void SetAudioVolume(int volume);
    public void SetSamplingFrequency(int freq);
}