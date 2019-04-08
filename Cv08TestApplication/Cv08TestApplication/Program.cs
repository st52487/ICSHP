using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv08TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("cesta souboru: ");
            string path = Console.ReadLine();
            Console.WriteLine(path);
            if(path.Equals(""))
            {
                path = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\.."));
            }
            Console.WriteLine("Vypsat do souboru nebo console? - soubor zadat nazev souboru, console - napsat console");
            string choise = Console.ReadLine();
            if (choise.Equals("console"))
            {
                try
                {
                    Console.WriteLine(GetDriveInfo(path));
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                ImportIntoFile(path);
            }
            Console.ReadKey();
        }

        private static void ImportIntoFile(string path)
        {
            try
            {
                using (StreamWriter outfile = new StreamWriter(path + @"\AllFiles.txt"))
                {
                    outfile.Write(GetDriveInfo(path).ToString());
                }
                Console.WriteLine("Informace uspesne zapsany v souboru! ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static StringBuilder GetDriveInfo(string path)
        {
            StringBuilder sb = new StringBuilder();
            if (Directory.Exists(path))
            {
                int countOfFiles = 0;
                int countOfDirectories = 0;
                DirectoryInfo df = new DirectoryInfo(path);

                FileInfo[] fi = df.GetFiles();
                DirectoryInfo[] di = df.GetDirectories();
                countOfFiles = getFiles(sb, countOfFiles, fi);

                sb.AppendLine();
                sb.AppendLine("Slozky - Nazev, datum vytvoreni");
                countOfDirectories = getDirectories(sb, countOfDirectories, di);
                sb.AppendLine();
                sb.AppendLine("Pocet souboru: " + countOfFiles + " Pocet slozek: " + countOfDirectories);
                sb.AppendLine();
                GetNumberOfFilesByExtesion(path, sb);
            }
            return sb;
        }

        private static void GetNumberOfFilesByExtesion(string path, StringBuilder sb)
        {
            var directoryInfoForExtensions = new DirectoryInfo(path);
            var extensionCounts = directoryInfoForExtensions.EnumerateFiles("*.*", SearchOption.AllDirectories)
                                    .GroupBy(x => x.Extension)
                                    .Select(g => new { Extension = g.Key, Count = g.Count() })
                                    .ToList();

            foreach (var group in extensionCounts)
            {
                sb.AppendLine("Pocet " + group.Extension + " souboru je: " + group.Count);
            }
        }

        private static int getFiles(StringBuilder sb, int countOfFiles, FileInfo[] fi)
        {
            sb.AppendLine("Soubory - Nazev, velikost, umisteni slozky, datum vytvoreni");
            sb.AppendLine();

            foreach (FileInfo file in fi)
            {
                countOfFiles++;
                sb.AppendLine(file.Name + " " + file.Length + " " + file.DirectoryName + " " + file.CreationTime);
            }

            return countOfFiles;
        }

        private static int getDirectories(StringBuilder sb, int countOfDirectories, DirectoryInfo[] di)
        {
            foreach (DirectoryInfo directory in di)
            {
                countOfDirectories++;
                sb.AppendLine(directory.Name + " " + directory.CreationTime + " " + directory.LastAccessTime);
            }

            return countOfDirectories;
        }
    }


}
