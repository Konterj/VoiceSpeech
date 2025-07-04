using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using VoiceChaker.Models;
using System.IO;
namespace VoiceChaker
{
    public class Main
    {
        public string _Path = "";
        string PathDefault = @"D:\Project VsCode\VoiceSpeech\VoiceSpeech\Models\VoiceSave\";
        public void OnIntilize()
        {
            OnStart();
        }
        public void OnStart()
        {
            Console.WriteLine(" ██▒   █▓ ▒█████   ██▓ ▄████▄  ▓█████   ██████  ██▓███  ▓█████ ▄▄▄       ██ ▄█▀▓█████  ██▀███  \r\n▓██░   █▒▒██▒  ██▒▓██▒▒██▀ ▀█  ▓█   ▀ ▒██    ▒ ▓██░  ██▒▓█   ▀▒████▄     ██▄█▒ ▓█   ▀ ▓██ ▒ ██▒\r\n ▓██  █▒░▒██░  ██▒▒██▒▒▓█    ▄ ▒███   ░ ▓██▄   ▓██░ ██▓▒▒███  ▒██  ▀█▄  ▓███▄░ ▒███   ▓██ ░▄█ ▒\r\n  ▒██ █░░▒██   ██░░██░▒▓▓▄ ▄██▒▒▓█  ▄   ▒   ██▒▒██▄█▓▒ ▒▒▓█  ▄░██▄▄▄▄██ ▓██ █▄ ▒▓█  ▄ ▒██▀▀█▄  \r\n   ▒▀█░  ░ ████▓▒░░██░▒ ▓███▀ ░░▒████▒▒██████▒▒▒██▒ ░  ░░▒████▒▓█   ▓██▒▒██▒ █▄░▒████▒░██▓ ▒██▒\r\n   ░ ▐░  ░ ▒░▒░▒░ ░▓  ░ ░▒ ▒  ░░░ ▒░ ░▒ ▒▓▒ ▒ ░▒▓▒░ ░  ░░░ ▒░ ░▒▒   ▓▒█░▒ ▒▒ ▓▒░░ ▒░ ░░ ▒▓ ░▒▓░\r\n   ░ ░░    ░ ▒ ▒░  ▒ ░  ░  ▒    ░ ░  ░░ ░▒  ░ ░░▒ ░      ░ ░  ░ ▒   ▒▒ ░░ ░▒ ▒░ ░ ░  ░  ░▒ ░ ▒░\r\n     ░░  ░ ░ ░ ▒   ▒ ░░           ░   ░  ░  ░  ░░          ░    ░   ▒   ░ ░░ ░    ░     ░░   ░ \r\n      ░      ░ ░   ░  ░ ░         ░  ░      ░              ░  ░     ░  ░░  ░      ░  ░   ░     \r\n     ░                ░                                                                        ");
            Console.WriteLine("==Voice Generator ==");
            Console.Beep(250, 1000);
            Console.Beep(650, 100);
            Console.WriteLine("\n" +
                "Введите путь к моделям Voice");
            string _Path = Console.ReadLine();
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            PathDefault = Path.Combine(baseDir, "Models", "Voices", "VoiceSave");
            var voice = new Voice();
            if(!voice.LoadFromFolder(_Path))
            {
                Console.WriteLine(_Path + ". Path Error don't exisest");
                Console.WriteLine("ERROR 200");
                return;
            }

            var decoder = new DecoderText(voice);
            var audio = new AudioManager();
            Console.Beep(550, 100);
            while (true)
            {
                Console.Write("\nВведите текст (или 'exit' для выхода): ");
                string input = Console.ReadLine();
                if (input.ToLower() == "exit") break;

                string wavPath = decoder.DecodeToWav(input, 0.5f);
                Console.WriteLine("Проигрываю голос...");
                audio.OnLaunchAudio(wavPath, 1f);

                Console.Write("Сохранить файл? (y/n): ");
                string save = Console.ReadLine();
                if (save.ToLower() == "y")
                {
                    Console.Write("\nИспользовать папку для сохранения голоса по умолчания?" +
                        "\nVoiceSave? " +
                        "(y/n): ");
                    string DefaultFolder = Console.ReadLine();
                    OnLoadDefaultSave();
                    if (DefaultFolder.ToLower() == "y")
                    {
                        Console.Write("Введите названия файла?\n" +
                            ":");
                        string outPath = Path.Combine(PathDefault, Console.ReadLine() + ".wav");
                        File.Copy(wavPath, outPath, overwrite: true);
                        Console.WriteLine($"Сохранено в: {outPath}");
                    }
                    File.Delete(wavPath);
                }
            }

            Console.WriteLine("Пока!");
        }

        public void OnLoadDefaultSave()
        {
            if (!Directory.Exists(PathDefault)) 
            {
                Directory.CreateDirectory(PathDefault);
                Console.WriteLine("Create a folder for save");
            }

        }
    }
}
