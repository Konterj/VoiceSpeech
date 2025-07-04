using System;
using System.IO;
using NAudio.Wave;
using VoiceChaker.Models;
using System.Threading;
namespace VoiceChaker
{
    public class DecoderText
    {        /// <summary>
             /// Настройка тишины, указывает длину тишины при паузах, и пунктуации.
             /// silenceSec = 0.1 короткая
             /// silenceSec = 0.5 Большая
             /// </summary>
        private readonly Voice _voice;
        private readonly Random _random = new();

        public DecoderText(Voice voice)
        {
            _voice = voice;
        }

        public string DecodeToWav(string text, float silenceSec)
        {
            string outputPath = Path.Combine(Path.GetTempPath(), $"output_{Guid.NewGuid()}.wav");

            var firstFile = _voice.WavFiles.Values.First();
            var waveFormat = new WaveFileReader(firstFile).WaveFormat;
            silenceSec = 0.2f;
            int bytesPerSecond = waveFormat.AverageBytesPerSecond;
            int silenceBytes = (int)(bytesPerSecond * silenceSec);
            byte[] silenceBuf = new byte[silenceBytes];

            using (var outputWriter = new WaveFileWriter(outputPath, waveFormat))
            {
                for (int i = 0; i < text.Length; i+= 2) 
                {
                    char currentChar = text[i];
                    if (char.IsWhiteSpace(currentChar) || char.IsPunctuation(currentChar))
                    {
                        outputWriter.Write(silenceBuf, 0, silenceBytes);
                        continue;
                    }

                    string randomWav = GetRandomWavFile();
                    if (randomWav == null) continue;
                    using var reader = new WaveFileReader(randomWav);
                    reader.CopyTo(outputWriter);
                }
            }

            return outputPath;
        }

        private string GetRandomWavFile()
        {
            if (_voice.WavFiles.Count == 0) return null;
            var values = _voice.WavFiles.Values.ToList();
            return values[_random.Next(values.Count)];
        }
    }
}
