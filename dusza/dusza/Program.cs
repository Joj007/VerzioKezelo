using System;
using System.IO;
using System.Linq;

namespace dusza;

internal class Program
{

    static void VisszaAllit(string utvonal)
    {
        string[] fajlok = Directory.GetFiles(utvonal);
        foreach (string fajl in fajlok)
        {
            if (fajl != ".dusza")
            {
                File.Delete($"{utvonal}\\{fajl}");
            }
        }
    }


    static void Main(string[] args)
    {

        void Inicalizalas(string path)
        {
            Directory.CreateDirectory(path + "/.dusza");
            string commitDirPath = $"/.dusza/{Directory.GetDirectories(path + "/.dusza").Count() + 1}. commit";
            Directory.CreateDirectory(path + commitDirPath);
            Directory.GetFiles(path).ToList().ForEach(fajl => File.Copy(fajl, path + $"/{commitDirPath}/{fajl.Split('\\')[fajl.Split('\\').Length - 1]}"));
            Directory.GetDirectories(path).Skip(1).ToList().ForEach(fajl => Directory.CreateDirectory(path + $"/{commitDirPath}/{fajl.Split('\\')[fajl.Split('\\').Length - 1]}"));
            File.WriteAllText(path + "/.dusza/head.txt", commitDirPath.Split('/')[2]);
        }





        string path = "C:\\Users\\sinka.jozsef\\Desktop\\teszt";
        Inicalizalas(path);

    }


}