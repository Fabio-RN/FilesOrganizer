# 📁 Download Organizer

> **A lightweight C# console app that keeps your Downloads folder clean — automatically.**

No more digging through a chaotic mess of files. Download Organizer sorts everything into the right place so you don't have to.

---

## ✨ Features

- 🗂️ **Smart file classification** — documents, media, programming files, and miscellaneous
- 🧩 **Modular architecture** — each file type is handled by its own dedicated class
- ⚡ **Lightweight & fast** — simple console app with no bloat
- 🕐 **Automation-ready** — schedule it via Windows Task Scheduler and forget about it

---

## 🛠️ Prerequisites

| Requirement | Version |
|---|---|
| Windows | 10 or higher |
| .NET | 6 or higher |

---

## 📦 Installation

**1. Clone the repository**
```bash
git clone https://github.com/YourUsername/Files_Organizer.git
```

**2. Open the project**

Open it in Visual Studio or any IDE of your choice.

**3. Build in Release mode**

Once built, your executable will be located at:
```
Files_Organizer\bin\Release\net6.0\Files_Organizer.exe
```

**4. (Optional) Move the executable**

Copy it anywhere you like for easier access.

---

## 🚀 Usage

1. **Run** the `.exe` by double-clicking it
2. **Watch** the console output — it shows which files were moved and where
3. **Press any key** to close the program once it's done

> ⚠️ **Note:** There is currently no ON/OFF toggle. Every time you run the program, it will organize **all** files according to their type.

---

## 🗃️ Supported File Types

| Category | Extensions |
|---|---|
| 📄 Documents | `pdf`, `docx`, `txt` |
| 🎬 Media | `mp4`, `mov`, `jpg`, `png`, `gif` |
| 💻 Programming | `cs`, `py`, `java` |
| 📦 Miscellaneous | `zip`, `rar` |

> You can add or modify file types by editing the logic inside each category class.

---

## ⏰ Run Automatically with Task Scheduler

Set it and forget it — let Windows handle the rest.

1. Open **Task Scheduler**
2. Click **Create Basic Task...**
3. Give it a name (e.g., `Download Organizer`)
4. Choose a **trigger** — daily, weekly, or at login
5. Set the **action** to `Start a Program`
6. Browse to your executable:
   ```
   Files_Organizer\bin\Release\net6.0\Files_Organizer.exe
   ```
7. *(Optional)* Check **Run Hidden** to suppress the console window
8. Click **Finish** and run the task once to test it

✅ Your downloads will now be organized automatically on your chosen schedule.

---

## 🤝 Contributing

Got ideas? Fork the repo and make it yours! Here are some areas to explore:

- 🆕 Support for more file types and custom categories
- 🔔 Desktop notifications after organizing
- 📋 Improved logging and history tracking
- 👁️ Real-time folder watching (no manual runs needed)

Pull requests are welcome!

---

## 📄 License

This project is licensed under the **MIT License** — free to use, modify, and distribute.
