using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Threading;
using System.Diagnostics;
namespace ConsoleFileManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> commands = new Dictionary<string, string>
        {
            { "createfile", "Creates a file at the specified directory." },
            { "deletefile", "Deletes a file at the specified directory." },
            { "editfile", "Edits a file using Notepad." },
            { "viewfile", "Views the content of a file." },
            { "createdirectory", "Creates a directory at the specified location." },
            { "copyfile", "Copies the file from the specified location to a different specified location, usage: copyfile <file> <directory1> <directory2>" },
        };
            while (true)
            {
                Console.WriteLine("Enter a command or 'exit' to quit:");
                string input = Console.ReadLine().ToLower();

                if (input == "exit")
                {
                    break;
                }
                else
                {
                    string[] parts = input.Split(' ');
                    string command = parts[0];

                    switch (command)
                    {
                        case "helpfilecommander":
                        case "help":
                            foreach (KeyValuePair<string, string> entry in commands)
                            {
                                Console.WriteLine(entry.Key);
                                Console.WriteLine(entry.Value);
                                Console.WriteLine();
                            }
                            break;
                        case "createfile":
                        case "cf":
                            if (parts.Length < 2)
                            {
                                Console.WriteLine("Usage: createfile [directory]. Type helpfilecommander for commands.");
                            }
                            else
                            {
                                string filename = parts[1];
                                CreateFile(filename);
                            }
                            break;
                        case "deletefile":
                        case "df":
                            if (parts.Length < 2)
                            {
                                Console.WriteLine("Usage: deletefile [directory]. Type helpfilecommander for commands.");
                            }
                            else
                            {
                                string filename = parts[1];
                                DeleteFile(filename);
                            }
                            break;
                        case "editfile":
                        case "ef":
                            if (parts.Length < 2)
                            {
                                Console.WriteLine("Usage: editfile [directory]. Type helpfilecommander for commands.");
                            }
                            else
                            {
                                string filename = parts[1];
                                EditFile(filename);
                            }
                            break;
                        case "viewfile":
                        case "vf":
                            if (parts.Length < 2)
                            {
                                Console.WriteLine("Usage: viewfile [directory]. Type helpfilecommander for commands.");
                            }
                            else
                            {
                                string filename = parts[1];
                                ViewFile(filename);
                            }
                            break;
                        case "createdirectory":
                        case "createdir":
                        case "crdir":
                        case "cdir":
                            if (parts.Length < 2)
                            {
                                Console.WriteLine("Usage: createdirectory [directory]. Type helpfilecommander for commands.");
                            }
                            else
                            {
                                string directory = parts[1];
                                CreateDirectory(directory);
                            }
                            break;
                        case "copyfile":
                        case "copyf":
                            if (parts.Length < 3)
                            {
                                Console.WriteLine("Usage: copyfile [filename] [filename]. Type helpfilecommander for commands.");
                            }
                            else
                            {
                                string filename1 = parts[1];
                                string filename2 = parts[2];
                                CopyFile(filename1, filename2);
                            }
                            break;
                        case "cutfile":
                        case "cutf":
                            if (parts.Length < 3)
                            {
                                Console.WriteLine("Usage: cutfile [filename] [filename]. Type helpfilecommander for commands.");
                            }
                            else
                            {
                                string filename1 = parts[1];
                                string filename2 = parts[2];
                                CutFile(filename1, filename2);
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid command. Type helpfilecommander for commands.");
                            break;
                    }
                }
            }
        }
        static void CreateFile(string filename)
        {
            try
            {
                if (File.Exists(filename))
                {
                    Console.WriteLine("The file that you are trying to create already exists. Try again.");
                }
                else
                {
                    using (File.Create(filename)) { }
                    Console.WriteLine($"Succesfully created {filename}!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error {ex.Message} while creating {filename}");
            }
        }
        static void DeleteFile(string filename)
        {
            try
            {
                File.Delete(filename);
                Console.WriteLine($"Successfully deleted {filename}!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error {ex.Message} while deleting {filename}");
            }
        }
        static void EditFile(string filename)
        {
            try
            {
                Process.Start("notepad.exe", filename);
                Console.WriteLine($"Opening {filename}, stay with us, this could take a moment.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error {ex.Message} while trying to edit {filename}");
            }
        }
        static void ViewFile(string filename)
        {
            try
            {
                Process.Start("viewfile.bat", filename);
                Console.WriteLine($"Opening {filename}, stay with us, this could take a moment.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error {ex.Message} while trying to open {filename}");
            }
        }
        static void CreateDirectory(string directory)
        {
            try
            {
                if (Directory.Exists(directory))
                {
                    Console.WriteLine("The directory you are trying to create already exists. Try again.");
                }
                else
                {
                    Directory.CreateDirectory(directory);
                    Console.WriteLine($"Successfully created {directory}.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error {ex.Message} while trying to create {directory}");
            }
        }
        static void CopyFile(string filename1, string filename2)
        {
            try
            {
                if (File.Exists(filename2))
                {
                    Console.WriteLine("The file that you are trying to copy already exists in the target direction. Try again.");
                }
                else
                {
                    File.Copy(filename1, filename2);
                    Console.WriteLine($"Successfully copied {filename1} from {filename1} to {filename2}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error {ex.Message} while trying to copy {filename1}");
            }
        }
        static void CutFile(string filename1, string filename2)
        {
            try
            {
                if (File.Exists(filename2))
                {
                    Console.WriteLine("The file that you are trying to copy already exists in the target direction. Try again.");
                }
                File.Move(filename1, filename2);
                Console.WriteLine($"Successfully moved {filename1} from {filename1} to {filename2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error {ex.Message} while trying to move {filename1}");
            }
        }
    }
}