# Deprecated, it's NOT a good piece of software. inefficient, clunky, hardcoded and just generally not very well made. It was a starters C# learning projects. Do with it what you will, if you want to clean up the mess, i accept pull requests.

# Console File Manager

ConsoleFileManager is a cross-platform program designed to simplify managing files and directories.

## Notes
- Currently, the feature `editfile` is windows-specific, as it requires the use of notepad.exe. Check the roadmap on what the plan is.
- You have to open the file to use the commands. Plans are to make it installable (either via an msi on windows or add it as a package on linux) so that it is usable system-wide

## Roadmap/To-Do
- Make the Linux version into a package so that it can be used system-wide.
- Make a MSI file so that you can install it on Windows
- Make the Linux file smaller in size, curently it's about 63MB, while the Windows exe is only 151Kb.
- delete directories.
- create a nano-like text editor so that `editfile` is cross-platform.

## Features

- **Create Files:** Create new text files.
- **Delete Files:** Remove files from your file system.
- **Edit Files:** Open and edit text files using Notepad.
- **View Files:** Display the content of text files.
- **Create Directories:** Create new directories or folders.
- **Copy Files:** Copy files from one location to another.
- **Move Files:** Move files from one location to another.
- **List Contents:** List files and subdirectories in a specified directory.

## Usage

The commands of ConsoleFileManager are simple, and designed to make it easy to use. they can always be accessed by simply using the command `helpfilecommander` or `help`, but they are also listed here:

- `createfile [filename]`: Create a new text file.
- `deletefile [filename]`: Delete a file.
- `editfile [filename]`: Edit a text file using Notepad.
- `viewfile [filename]`: View the content of a text file.
- `createdirectory [directory]`: Create a new directory.
- `copyfile [source] [destination]`: Copy a file to another location.
- `movefile [source] [destination]`: Move a file to another location.
- `listcontent [directory]`: List files and subdirectories in a directory.

## Compatibility

This Console File Manager is designed to be cross-compatible for all operating systems, made possible with C# .NET 7. Current tested operating systems:
- Windows 10 22H2
- EndaevourOS Cassini Nova 03 R3 with GNOME DE (Arch Linux)

## Getting Started

### Windows:
1. Simply download the exe file on the releases page
2. Run the file

### Linux:
1. Download the Linux-compatible file on the releases page
2. Run the file via a command line by running `~/directory/`
3. This should do the trick

## Contributions

Contributions and suggestions are welcome! If you have ideas to enhance this tool, please submit a pull request or open an issue.

## License

**To be made**

Happy file managing!
