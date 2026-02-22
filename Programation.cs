using System.IO;
using System.Linq;
using System;

namespace Files_Organizer;

class ProgramationFiles
{
    public void OrganizeProgramation()
    {
        string carpetaOrigen = @"C:\Users\Fabio\Downloads\";
        string carpetaCs = @"C:\Users\Fabio\Downloads\Programacion\CSs";
        string carpetaJson = @"C:\Users\Fabio\Downloads\Programacion\JSONs";
        string carpetaTxt = @"C:\Users\Fabio\Downloads\Programacion\TXTs";
        string carpetaJava = @"C:\Users\Fabio\Downloads\Programacion\JARs";
        string carpetaPython = @"C:\Users\Fabio\Downloads\Programacion\PYs";
        string carpetaHTML = @"C:\Users\Fabio\Downloads\Programacion\HTMLs";
        string carpetaJavaScript = @"C:\Users\Fabio\Downloads\Programacion\JSs";
        string carpetaXml = @"C:\Users\Fabio\Downloads\Programacion\XMLs";

        // Asegurarse de que las carpetas destino existan
        if (!Directory.Exists(carpetaCs))
            Directory.CreateDirectory(carpetaCs);
        if (!Directory.Exists(carpetaJson))
            Directory.CreateDirectory(carpetaJson);
        if (!Directory.Exists(carpetaTxt))
            Directory.CreateDirectory(carpetaTxt);
        if (!Directory.Exists(carpetaJava))
            Directory.CreateDirectory(carpetaJava);
        if (!Directory.Exists(carpetaPython))
            Directory.CreateDirectory(carpetaPython);
        if (!Directory.Exists(carpetaHTML))
            Directory.CreateDirectory(carpetaHTML);
        if (!Directory.Exists(carpetaJavaScript))
            Directory.CreateDirectory(carpetaJavaScript);
        if (!Directory.Exists(carpetaXml))
            Directory.CreateDirectory(carpetaXml);

        string[] cs = Directory.GetFiles(carpetaOrigen, "*.cs", SearchOption.TopDirectoryOnly);
        string[] json = Directory.GetFiles(carpetaOrigen, "*.json", SearchOption.TopDirectoryOnly);
        string[] txt = Directory.GetFiles(carpetaOrigen, "*.txt", SearchOption.TopDirectoryOnly);
        string[] java = Directory.GetFiles(carpetaOrigen, "*.jar", SearchOption.TopDirectoryOnly);
        string[] python = Directory.GetFiles(carpetaOrigen, "*.py", SearchOption.TopDirectoryOnly);
        string[] html = Directory.GetFiles(carpetaOrigen, "*.html", SearchOption.TopDirectoryOnly);
        string[] javascript = Directory.GetFiles(carpetaOrigen, "*.js", SearchOption.TopDirectoryOnly);
        string[] xml = Directory.GetFiles(carpetaOrigen, "*.xml", SearchOption.TopDirectoryOnly);

        foreach (string archivo in java)
        {
            string nombreArchivo = Path.GetFileName(archivo);
            string rutaDestino = Path.Combine(carpetaJava, nombreArchivo);

            File.Move(archivo, rutaDestino);
            Console.WriteLine($"Movido: {nombreArchivo}");
        }

        foreach (string archivo in txt)
        {
            string nombreArchivo = Path.GetFileName(archivo);
            string rutaDestino = Path.Combine(carpetaTxt, nombreArchivo);

            File.Move(archivo, rutaDestino);
            Console.WriteLine($"Movido: {nombreArchivo}");
        }

        foreach (string archivo in json)
        {
            string nombreArchivo = Path.GetFileName(archivo);
            string rutaDestino = Path.Combine(carpetaJson, nombreArchivo);

            File.Move(archivo, rutaDestino);
            Console.WriteLine($"Movido: {nombreArchivo}");
        }
        foreach(string archivo in cs)
        {
            string nombreArchivo = Path.GetFileName(archivo);
            string rutaDestino = Path.Combine(carpetaCs, nombreArchivo);

            File.Move(archivo, rutaDestino);
            Console.WriteLine($"Movido: {nombreArchivo}");
        }
        foreach(string archivo in python)
        {
            string nombreArchivo = Path.GetFileName(archivo);
            string rutaDestino = Path.Combine(carpetaPython, nombreArchivo);

            File.Move(archivo, rutaDestino);
            Console.WriteLine($"Movido: {nombreArchivo}");
        }
        foreach(string archivo in html)
        {
            string nombreArchivo = Path.GetFileName(archivo);
            string rutaDestino = Path.Combine(carpetaHTML, nombreArchivo);

            File.Move(archivo, rutaDestino);
            Console.WriteLine($"Movido: {nombreArchivo}");
        }
        foreach(string archivo in javascript)
        {
            string nombreArchivo = Path.GetFileName(archivo);
            string rutaDestino = Path.Combine(carpetaJavaScript, nombreArchivo);

            File.Move(archivo, rutaDestino);
            Console.WriteLine($"Movido: {nombreArchivo}");
        }
        foreach(string archivo in xml)
        {
            string nombreArchivo = Path.GetFileName(archivo);
            string rutaDestino = Path.Combine(carpetaXml, nombreArchivo);

            File.Move(archivo, rutaDestino);
            Console.WriteLine($"Movido: {nombreArchivo}");
        }
    }
}