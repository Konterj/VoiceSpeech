using NAudio.Wave;
using NAudio.Wave.SampleProviders;

public class AudioManager
{
    
    /// <summary>
    /// Проигрывает WAV-файл с возможностью задать скорость.
    /// speed = 1.0 — оригинальная скорость,
    /// speed = 0.5 — в 2 раза медленнее,
    /// speed = 2.0 — в 2 раза быстрее.
    /// </summary>
    public void OnLaunchAudio(string path, float speed = 1.0f)
    {
        // 1) Открываем исходник
        using var reader = new AudioFileReader(path);

        ISampleProvider playbackProvider;

        if (Math.Abs(speed - 1.0f) < 0.0001f)
        {
            // Без изменения скорости
            playbackProvider = reader;
        }
        else
        {
            // 2) Вычисляем новую частоту
            int newSampleRate = (int)(reader.WaveFormat.SampleRate * speed);
            // 3) Создаём формат с этой частотой (16‑бит PCM)
            var newFormat = new WaveFormat(newSampleRate, reader.WaveFormat.BitsPerSample, reader.WaveFormat.Channels);
            // 4) Ресэмплим через MediaFoundationResampler
            var resampler = new MediaFoundationResampler(reader, newFormat)
            {
                ResamplerQuality = 60,  // можно от 1 до 60
            };
            playbackProvider = resampler.ToSampleProvider();
        }

        // 5) Проигрываем
        using var outputDevice = new WaveOutEvent();
        outputDevice.Init(playbackProvider);
        outputDevice.Play();

        // Ждём окончания
        while (outputDevice.PlaybackState == PlaybackState.Playing)
            System.Threading.Thread.Sleep(100);
    }
}
