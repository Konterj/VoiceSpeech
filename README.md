<!-- Hero Section -->

<pre align="center">
 __      __   _             ___                      _     
 \ \    / /  (_)         / ____|                    | |    
  \ \  / /__  _  ___ ___| (___  _ __   ___  ___  ___| |__  
   \ \/ / _ \| |/ __/ _ \\___ \| '_ \ / _ \/ _ \/ __| '_ \ 
    \  / (_) | | (_|  __/____) | |_) |  __/  __/ (__| | | |
     \/ \___/|_|\___\___|_____/| .__/ \___|\___|\___|_| |_|
                               | |                         
                               |_|                         
</pre>

<p align="center">Мини‑консольный синтезатор речи в стиле Animal Crossing на C# (<a href="https://dotnet.microsoft.com/en-us/">.NET 9</a>) с использованием <a href="https://github.com/naudio/NAudio">NAudio</a></p>

<p align="center">
  <a href="#rus"><kbd>RU</kbd></a>
  <a href="#eng"><kbd>EN</kbd></a>
</p>

<p align="center">
  <a href="https://github.com/username/VoiceSpeech/stargazers"><img src="https://img.shields.io/github/stars/username/VoiceSpeech?style=social" alt="GitHub stars"/></a>
  <a href="https://github.com/username/VoiceSpeech/actions"><img src="https://img.shields.io/github/actions/workflow/status/username/VoiceSpeech/dotnet.yml?branch=main" alt="Build status"/></a>
  <a href="LICENSE"><img src="https://img.shields.io/github/license/username/VoiceSpeech" alt="License: MIT"/></a>
</p>

---

## 📖 Содержание

1. [RU Описание](#rus)
2. [EN Quickstart](#eng)
3. [Структура проекта](#project-structure)
4. [Функционал / Features](#features)
5. [Установка и запуск](#getting-started)
6. [Технологии / Tech](#technologies)
7. [Лицензия](#license)

---

## 🎯 RU Описание <a id="rus"></a>

VoiceSpeech — консольный синтезатор речи в духе Animal Crossing:

* Разбивает входной текст на слоги
* Собирает случайные `.wav` файлы из папок `High` и `Low`
* Склеивает их в единый аудиопоток
* Воспроизводит через NAudio
* Опционально сохраняет итоговый WAV в `Models/VoiceSave/`

---

## 🎯 EN Quickstart <a id="eng"></a>

VoiceSpeech is a lightweight console-based speech synthesizer inspired by Animal Crossing:

* Splits input text into syllables
* Selects random `.wav` clips from `High` and `Low` folders
* Concatenates them into one audio stream
* Plays via NAudio
* Optionally saves the resulting WAV to `Models/VoiceSave/`

---

## 🗂 Структура проекта <a id="project-structure"></a>

```text
VoiceSpeech/
├─ Models/
│   ├─ Voices/
│   │   ├─ High/       # high-pitch clips
│   │   └─ Low/        # low-pitch clips
│   └─ VoiceSave/     # saved WAVs
├─ AudioManager.cs     # audio handling logic
├─ BeepAudio.cs        # placeholder for Console.Beep()
├─ DecoderText.cs      # text-to-syllable decoder
├─ Main.cs             # test runner
├─ Program.cs          # console CLI
└─ VoiceChaker.Models/
    └─ Voice.cs        # audio clip model
```

---

## 🎯 Функционал / Features <a id="features"></a>

* **Speech Generation**: text → `.wav`
* **Playback**: via NAudio
* **Save**: store output in `Models/VoiceSave/`
* **BeepAudio**: proof-of-concept `Console.Beep()` support

<details>
<summary>Пример / Example</summary>

```bash
# Russian example
dotnet run -- "Привет, мир!"
# English example
dotnet run -- "Hello, world!"
```

</details>

---

## 🚀 Установка и запуск <a id="getting-started"></a>

<p align="center">
  <img src="https://img.shields.io/badge/dotnet-9.0-blue" alt=".NET 9"/>&nbsp;
  <img src="https://img.shields.io/badge/C%23-10.0-blueviolet" alt="C# 10"/>&nbsp;
  <img src="https://img.shields.io/badge/NAudio-2.1-green" alt="NAudio"/>
</p>

1. Клонируйте репозиторий:

   ```bash
   git clone https://github.com/username/VoiceSpeech.git
   cd VoiceSpeech
   ```
2. Откройте проект в Visual Studio 2022 или VS Code:

   ```bash
   code .
   ```
3. Восстановите зависимости и запустите:

   ```bash
   dotnet restore
   dotnet run --project VoiceSpeech
   ```

---

## ⚒️ Технологии / Tech <a id="technologies"></a>

<p align="center">
  <kbd>C#</kbd> <kbd>.NET 9</kbd> <kbd>NAudio</kbd> <kbd>Console</kbd>
  <kbd>Visual Studio 2022</kbd> <kbd>VS Code</kbd> <kbd>Audacity</kbd>
</p>

---

## 📄 Лицензия <a id="license"></a>

Этот проект лицензируется под [MIT License](LICENSE).
© 2025 Junior+/Middle C# Developer
