fileMover-UI is a lightweight desktop utility designed to automate the organization of cluttered folders—specifically. By sorting files based on their extensions into user-defined repositories, it turns a chaotic list of files into a structured system in a single click.

✨ Features
Smart Sorting: Group files by type (Images, Documents, Installers, etc.) into dedicated folders.

Filename Cleanup: Automatically remove "junk" text from filenames (e.g., (1), [Official], _v2) during the move process.

Persistence: Saves your folder configurations and cleanup rules so you only have to set them up once.

Safety First: Includes checks to ensure files aren't overwritten and provides clear error logging for access-denied issues.

Automatic Directory Creation: Toggles to create destination folders automatically if they don't exist.

🚀 Getting Started
Prerequisites
Windows 10 or 11

.NET Runtime (Version 5.0 or higher recommended)

Installation
Download the latest release from the Releases tab.

Extract the .zip file to a location of your choice.

Run fileMover.exe.

[!IMPORTANT]
Upgrading from v0.2? > Please delete the fileRepositories.txt file located in the /Data folder before launching the new version to ensure compatibility with the updated save system.

🛠 Usage
Select Source: Define the "Root Path" (e.g., your Downloads folder).

Configure Repositories: Use the checkboxes to select which file types you want to move and browse for their destination folders.

Clean Filenames: Add "Unwanted Words" in the UI settings. Any file being moved that contains these words will have them stripped from the name automatically.

Run: Click the move button and watch the live log populate as your files are organized.

🗺 Roadmap
[x] Basic file moving by extension

[x] UI-based configuration saving/loading

[x] Case-insensitive filename cleanup

[ ] Upcoming: JSON-based configuration for better stability

[ ] Upcoming: Regex support for advanced filename cleaning

[ ] Upcoming: "Undo" functionality to revert the last move operation


📄 License
Distributed under the MIT License. See LICENSE for more information.

📧 Contact
Pike Theunissen - pikechristheunissen@gmail.com

Project Link: https://github.com/PikeTheunissen/fileMover-UI
