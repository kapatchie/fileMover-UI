using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace ConsoleUI
{
    static class FileManager
    {
        public static List<string> wordsToDelete = new List<string>();
        public static bool checkDestination(bool createDestination, string path)
        {
            if (createDestination)
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                return true;
            }
            else if (Directory.Exists(path))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static string[] GetFilesToMove(string rootPath, string Extension)
        {
            return Directory.GetFiles(rootPath, $"*.{Extension}");
        }
        private static void MoveFile(string newLocation, string Extension, string rootPath)
        {
            foreach (var file in GetFilesToMove(rootPath, Extension))
            {
                string newFileName = UnwantedTextRemover(Path.GetFileName(file));
                newFileName = Path.Combine(newLocation, newFileName);
                if (!File.Exists(newFileName))
                {
                    File.Move(file, newFileName);
                    UIController.Instance.text += ("Moving File " + Path.GetFileName(file) + "*");
                }
                else
                { UIController.Instance.text += ($"File :{ Path.GetFileName(file)} all ready exists skipping file" + "*"); }
            }
        }

        private static string UnwantedTextRemover(string text)
        {
            foreach (var unwanted in wordsToDelete)
            {
                text = text.Contains(unwanted) ? text.Replace(unwanted, "") : text;
            }
            return text;
        }
        public static void saveData(List<Repository> repositories)
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Data");
            string fileDestinationPath = path + @"\fileRespsitories.txt";
            checkDestination(true, path);

            StringBuilder sb = new StringBuilder();
            StreamWriter sw;

            File.WriteAllText(fileDestinationPath, "");
            try
            {
                sw = new StreamWriter(fileDestinationPath, false, Encoding.UTF8);

                foreach (var repository in repositories)
                {
                    sb.Append("Destination =").Append(repository.Destination).Append(',');
                    sb.Append("Repository =").Append(repository.Type).Append(',');
                }
                Console.WriteLine(sb.ToString());
                sw.WriteLine(sb.ToString());
                sw.Close();
            }
            catch (Exception e)
            {
                UIController.Instance.text += (e + "*");
            }
            finally
            {
                sb.Clear();
            }
        }

        public static List<Repository> loadData()
        {
            List<Repository> dataList = new List<Repository>();
            try
            {
                string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Data");
                string text = File.ReadAllText(path + @"\fileRespsitories.txt");

                text = text.Replace(Environment.NewLine, string.Empty);
                string[] dataArray = text.Split(',');
                Repository repository = new Repository();
                foreach (var data in dataArray)
                {

                    if (!string.IsNullOrEmpty(data))
                    {
                        if (data.Contains("Repository ="))
                        {
                            string _temp = data;
                            _temp = _temp.Replace("Repository =", "");
                            repository.Type = int.TryParse(_temp, out int Value) ? repository.Type = Value : repository.Type = 0;
                        }

                        if (data.Contains("Destination ="))
                        {
                            string _temp = data;
                            _temp = _temp.Replace("Destination =", "");
                            repository.Destination = _temp;
                        }
                    }

                    if (!string.IsNullOrEmpty(repository.Destination) && repository.Type != 0)
                    {
                        dataList.Add(repository);
                        repository = new Repository();
                    }
                }
                foreach (var file in dataList)
                {
                    string _path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), file.Destination);
                    checkDestination(true, _path);
                }
                return dataList;
            }
            catch (Exception e)
            {
                return dataList;
            }
        }
        public static void MoveFiles(List<Repository> fileRepository, bool createLocation, string rootPath)
        {
            foreach (var repository in fileRepository)
            {
                List<string> _extensions = new List<string>();
                FileData fileData = new FileData(repository.Type);
                _extensions.AddRange(fileData.fileExtensions);

                if (checkDestination(false, rootPath))
                {
                    foreach (var extension in _extensions)
                    {
                        MoveFile(repository.Destination, extension, rootPath);
                    }
                }
            }
        }
    }
}
