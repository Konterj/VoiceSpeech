<!-- Hero Section -->
<div align="center">

```
             _          __                      _     
 /\   /\___ (_) ___ ___/ _\_ __   ___  ___  ___| |__  
 \ \ / / _ \| |/ __/ _ \ \| '_ \ / _ \/ _ \/ __| '_ \ 
  \ V / (_) | | (_|  __/\ \ |_) |  __/  __/ (__| | | |
   \_/ \___/|_|\___\___\__/ .__/ \___|\___|\___|_| |_|
                                                        
```

</div>

<p align="center">
  A mini-console speech synthesizer in the style of Animal Crossing, built in C# (<a href="https://dotnet.microsoft.com/en-us/">.NET 9</a>) using <a href="https://github.com/naudio/NAudio">NAudio</a>.
</p>

<p align="center">
  <a href="#english-version"><kbd>🇬🇧 EN</kbd></a>
  ·
  <a href="#russian-version"><kbd>🇷🇺 RU</kbd></a>
</p>

---

<h2 id="english-version">🇬🇧 English Version</h2>

VoiceSpeech is a lightweight console-based speech synthesizer inspired by Animal Crossing. It works by taking text input, breaking it down into syllables, and then stitching together short, pre-recorded audio clips to generate a playful, "beeping" voice output.

### ✨ Features

* **Syllable-based Synthesis**: Splits input text into syllables for more natural-sounding gibberish.
* **Randomized Audio**: Selects random `.wav` clips from `High` and `Low` pitch folders.
* **Audio Concatenation**: Merges the selected clips into a single audio stream.
* **Playback**: Plays the final audio directly in the console using NAudio.
* **Save to File**: Optionally saves the generated speech as a `.wav` file in the `Models/VoiceSave/` directory.

---

### 🗂 Project Structure

```text
VoiceSpeech/
├─ Models/
│   ├─ Voices/
│   │   ├─ High/         # High-pitch .wav clips
│   │   └─ Low/          # Low-pitch .wav clips
│   └─ VoiceSave/      # Directory for saved WAVs
├─ AudioManager.cs     # Core audio handling logic (NAudio)
├─ DecoderText.cs      # Text-to-syllable decoding logic
├─ Program.cs          # Main entry point and console CLI
└─ ... other project files
```

---

### 🚀 Getting Started

To get a local copy up and running, follow these simple steps.

#### Prerequisites

* [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
* An IDE like [Visual Studio 2022](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)

#### Installation & Running

1.  Clone the repo:
    ```bash
    # IMPORTANT: Replace 'username' with the actual repository owner's username
    git clone [https://github.com/username/VoiceSpeech.git](https://github.com/username/VoiceSpeech.git)
    cd VoiceSpeech
    ```
2.  Restore dependencies and run the project:
    ```bash
    dotnet restore
    dotnet run -- "Hello, world!"
    ```
3.  To synthesize Russian text:
    ```bash
    dotnet run -- "Привет, мир!"
    ```

---

### 🛠️ Technologies Used

<p align="center">
  <kbd>C#</kbd>
  <kbd>.NET 9</kbd>
  <kbd>NAudio</kbd>
  <kbd>Console</kbd>
  <kbd>Visual Studio 2022</kbd>
</p>

---

### 📄 License

Distributed under the MIT License. See `LICENSE` for more information.

<p align="right">(<a href="#top">back to top</a>)</p>

---
---

<details>
<summary><h2 id="russian-version">🇷🇺 Russian Version (Нажмите, чтобы развернуть)</h2></summary>

VoiceSpeech — это консольный синтезатор речи в духе Animal Crossing. Он принимает на вход текст, разбивает его на слоги, а затем "озвучивает", склеивая короткие аудио-фрагменты для создания характерного игрового голоса.

### ✨ Функционал

* **Синтез на основе слогов**: Разбивает входной текст на слоги для более естественного звучания.
* **Случайные звуки**: Выбирает случайные `.wav` файлы из папок с высокими (`High`) и низкими (`Low`) звуками.
* **Объединение аудио**: Склеивает выбранные клипы в единый аудиопоток.
* **Воспроизведение**: Проигрывает итоговый звук прямо в консоли с помощью библиотеки NAudio.
* **Сохранение в файл**: Позволяет сохранить результат в виде `.wav` файла в директорию `Models/VoiceSave/`.

---

### 🗂 Структура проекта

```text
VoiceSpeech/
├─ Models/
│   ├─ Voices/
│   │   ├─ High/         # .wav файлы с высоким тоном
│   │   └─ Low/          # .wav файлы с низким тоном
│   └─ VoiceSave/      # Папка для сохраненных WAV-файлов
├─ AudioManager.cs     # Логика по работе с аудио (NAudio)
├─ DecoderText.cs      # Логика для разделения текста на слоги
├─ Program.cs          # Точка входа и интерфейс командной строки
└─ ... другие файлы проекта
```

---

### 🚀 Установка и запуск

Следуйте этим шагам, чтобы запустить проект локально.

#### Требования

* [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
* Среда разработки, например [Visual Studio 2022](https://visualstudio.microsoft.com/) или [VS Code](https://code.visualstudio.com/)

#### Установка и запуск

1.  Клонируйте репозиторий:
    ```bash
    # ВАЖНО: Замените 'username' на имя пользователя владельца репозитория
    git clone [https://github.com/username/VoiceSpeech.git](https://github.com/username/VoiceSpeech.git)
    cd VoiceSpeech
    ```
2.  Восстановите зависимости и запустите проект:
    ```bash
    dotnet restore
    dotnet run -- "Привет, мир!"
    ```
3.  Для синтеза английской речи:
    ```bash
    dotnet run -- "Hello, world!"
    ```

---

### 🛠️ Используемые технологии

<p align="center">
  <kbd>C#</kbd>
  <kbd>.NET 9</kbd>
  <kbd>NAudio</kbd>
  <kbd>Console</kbd>
  <kbd>Visual Studio 2022</kbd>
</p>

---

### 📄 Лицензия

Проект распространяется по лицензии MIT. Подробности в файле `LICENSE`.

<p align="right">(<a href="#top">наверх</a>)</p>

</details>
