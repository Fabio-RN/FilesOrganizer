using System.IO;
using System.Linq;
using System;

namespace Files_Organizer;

class ProgrammingFiles
{
    public void OrganizeProgramming()
    {
        string sourcePath = @"C:\Users\Fabio\Downloads\";
        string csPath = @"C:\Users\Fabio\Downloads\Programming\CSs";
        string jsonPath = @"C:\Users\Fabio\Downloads\Programming\JSONs";
        string txtPath = @"C:\Users\Fabio\Downloads\Programming\TXTs";
        string javaPath = @"C:\Users\Fabio\Downloads\Programming\JARs";
        string pythonPath = @"C:\Users\Fabio\Downloads\Programming\PYs";
        string htmlPath = @"C:\Users\Fabio\Downloads\Programming\HTMLs";
        string javascriptPath = @"C:\Users\Fabio\Downloads\Programming\JSs";
        string xmlPath = @"C:\Users\Fabio\Downloads\Programming\XMLs";

        // Ensure that the destination folders exist
        if (!Directory.Exists(csPath))
            Directory.CreateDirectory(csPath);
        if (!Directory.Exists(jsonPath))
            Directory.CreateDirectory(jsonPath);
        if (!Directory.Exists(txtPath))
            Directory.CreateDirectory(txtPath);
        if (!Directory.Exists(javaPath))
            Directory.CreateDirectory(javaPath);
        if (!Directory.Exists(pythonPath))
            Directory.CreateDirectory(pythonPath);
        if (!Directory.Exists(htmlPath))
            Directory.CreateDirectory(htmlPath);
        if (!Directory.Exists(javascriptPath))
            Directory.CreateDirectory(javascriptPath);
        if (!Directory.Exists(xmlPath))
            Directory.CreateDirectory(xmlPath);

        string[] cs = Directory.GetFiles(sourcePath, "*.cs", SearchOption.TopDirectoryOnly);
        string[] json = Directory.GetFiles(sourcePath, "*.json", SearchOption.TopDirectoryOnly);
        string[] txt = Directory.GetFiles(sourcePath, "*.txt", SearchOption.TopDirectoryOnly);
        string[] java = Directory.GetFiles(sourcePath, "*.jar", SearchOption.TopDirectoryOnly);
        string[] python = Directory.GetFiles(sourcePath, "*.py", SearchOption.TopDirectoryOnly);
        string[] html = Directory.GetFiles(sourcePath, "*.html", SearchOption.TopDirectoryOnly);
        string[] javascript = Directory.GetFiles(sourcePath, "*.js", SearchOption.TopDirectoryOnly);
        string[] xml = Directory.GetFiles(sourcePath, "*.xml", SearchOption.TopDirectoryOnly);

        foreach (string file in java)
        {
            string fileName = Path.GetFileName(file);
            string destinationPath = Path.Combine(javaPath, fileName);

            File.Move(file, destinationPath);
            Console.WriteLine($"Moved: {fileName}");
        }

        foreach (string file in txt)
        {
            string fileName = Path.GetFileName(file);
            string destinationPath = Path.Combine(txtPath, fileName);

            File.Move(file, destinationPath);
            Console.WriteLine($"Moved: {fileName}");
        }

        foreach (string file in json)
        {
            string fileName = Path.GetFileName(file);
            string destinationPath = Path.Combine(jsonPath, fileName);

            File.Move(file, destinationPath);
            Console.WriteLine($"Moved: {fileName}");
        }
        foreach(string file in cs)
        {
            string fileName = Path.GetFileName(file);
            string destinationPath = Path.Combine(csPath, fileName);

            File.Move(file, destinationPath);
            Console.WriteLine($"Moved: {fileName}");
        }
        foreach(string file in python)
        {
            string fileName = Path.GetFileName(file);
            string destinationPath = Path.Combine(pythonPath, fileName);

            File.Move(file, destinationPath);
            Console.WriteLine($"Moved: {fileName}");
        }
        foreach(string file in html)
        {
            string fileName = Path.GetFileName(file);
            string destinationPath = Path.Combine(htmlPath, fileName);

            File.Move(file, destinationPath);
            Console.WriteLine($"Moved: {fileName}");
        }
        foreach(string file in javascript)
        {
            string fileName = Path.GetFileName(file);
            string destinationPath = Path.Combine(javascriptPath, fileName);

            File.Move(file, destinationPath);
            Console.WriteLine($"Moved: {fileName}");
        }
        foreach(string file in xml)
        {
            string fileName = Path.GetFileName(file);
            string destinationPath = Path.Combine(xmlPath, fileName);

            File.Move(file, destinationPath);
            Console.WriteLine($"Moved: {fileName}");
        }
    }
}