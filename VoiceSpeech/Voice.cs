using System;
using System.Collections.Generic;
using System.IO;

namespace VoiceChaker.Models
{
    public class Voice
    {
        public string Name { get; set; }
        public string FolderPath { get; set; }
        public Dictionary<string, string> WavFiles { get; set; } = new();

        public bool LoadFromFolder(string path)
        {
            if (!Directory.Exists(path)) return false;

            FolderPath = path;

            foreach (var file in Directory.GetFiles(path, "*.wav"))
            {
                var key = Path.GetFileNameWithoutExtension(file).ToLower();
                WavFiles[key] = file;
            }

            return WavFiles.Count > 0;
        }

        public string GetWavForChar(char c)
        {
            var key = c.ToString().ToLower();
            return WavFiles.TryGetValue(key, out string? value) ? value : null;
        }
    }
}
