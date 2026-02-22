using System.IO;
using System.Linq;
using System;

namespace Files_Organizer;

class MiscellaneousFiles
{
    public void OrganizeMiscellaneous()
    {
        string carpetaOrigen = @"C:\Users\Fabio\Downloads\";
        string carpetaMsis = @"C:\Users\Fabio\Downloads\Miscelaneous\MSIs";
        string carpetaIsos = @"C:\Users\Fabio\Downloads\Miscelaneous\Isos";
        string carpetaExes = @"C:\Users\Fabio\Downloads\Miscelaneous\EXEs";
        string carpetaZips = @"C:\Users\Fabio\Downloads\Miscelaneous\Zips";
        string carpetaRars = @"C:\Users\Fabio\Downloads\Miscelaneous\Rars";

        // Asegurarse de que las carpetas destino existan
        if (!Directory.Exists(carpetaMsis))
            Directory.CreateDirectory(carpetaMsis);
        if (!Directory.Exists(carpetaIsos))
            Directory.CreateDirectory(carpetaIsos);
        if (!Directory.Exists(carpetaExes))
            Directory.CreateDirectory(carpetaExes);
        if (!Directory.Exists(carpetaZips))
            Directory.CreateDirectory(carpetaZips);
        if (!Directory.Exists(carpetaRars))
            Directory.CreateDirectory(carpetaRars);

        string[] executables = Directory.GetFiles(carpetaOrigen, "*.exe", SearchOption.TopDirectoryOnly)
            .Concat(Directory.GetFiles(carpetaOrigen, "*.msi", SearchOption.TopDirectoryOnly))
            .Concat(Directory.GetFiles(carpetaOrigen, "*.iso", SearchOption.TopDirectoryOnly))
            .ToArray();
        string[] Comprimidos = Directory.GetFiles(carpetaOrigen, "*.zip", SearchOption.TopDirectoryOnly)
            .Concat(Directory.GetFiles(carpetaOrigen, "*.rar", SearchOption.TopDirectoryOnly))
            .ToArray();

        foreach (string archivo in executables)
        {
            string nombreArchivo = Path.GetFileName(archivo);
            string rutaDestinoExes = Path.Combine(carpetaExes, nombreArchivo);
            string rutaDestinoMsi = Path.Combine(carpetaMsis, nombreArchivo);
            string rutaDestinoIso = Path.Combine(carpetaIsos, nombreArchivo);
            if (archivo.EndsWith(".exe"))
                File.Move(archivo, rutaDestinoExes);
            else if (archivo.EndsWith(".msi"))
                File.Move(archivo, rutaDestinoMsi);
            else if (archivo.EndsWith(".iso"))
                File.Move(archivo, rutaDestinoIso);
        }
        foreach (string archivo in Comprimidos)
        {
            string nombreArchivo = Path.GetFileName(archivo);
            string rutaDestino = Path.Combine(carpetaZips, nombreArchivo);
            string rutaDestinoRar = Path.Combine(carpetaRars, nombreArchivo);
            if(archivo.EndsWith(".zip"))
                File.Move(archivo, rutaDestino);
            else if (archivo.EndsWith(".rar"))
                File.Move(archivo, rutaDestinoRar);
        }
    }
}