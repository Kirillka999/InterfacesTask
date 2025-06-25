namespace InterfacesTask;

public class SmartWatch : IAudioPrinter
{
    private int _audioVolume;
    private int _samplingFrequency;
    private int AudioVolume
    {
        get
        {
            return _audioVolume;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Can not set volume to negative");
            }

            _audioVolume = value;
        }
    }

    private int SamplingFrequency
    {
        get
        {
            return _samplingFrequency;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Can not set frequency to negative");
            }

            _samplingFrequency = value;
        }
    }

    public SmartWatch()
    {
        AudioVolume = 100;
        SamplingFrequency = 125;
    }
    
    public void PrintMessage(string message)
    {
        if (AudioVolume > 10 && SamplingFrequency >= 8)
        {
            // Watch TTS logic
            Console.WriteLine($"(SmartWatch) Message {message} was played on smartwatch.");
        }
        else
        {
            throw new InvalidOperationException("Can not play message: volume or freq are too low");
        }
    }

    public void SetAudioVolume(int volume)
    {
        AudioVolume = volume;
    }

    public void SetSamplingFrequency(int freq)
    {
        SamplingFrequency = freq;
    }
}