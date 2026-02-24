using System.IO;
using System.Linq;
using System;

namespace Files_Organizer;

class MiscellaneousFiles
{
    public void OrganizeMiscellaneous()
    {
        string sourcePath = @"C:\Users\Fabio\Downloads\";
        string msiPath = @"C:\Users\Fabio\Downloads\Miscellaneous\MSIs";
        string isoPath = @"C:\Users\Fabio\Downloads\Miscellaneous\Isos";
        string exePath = @"C:\Users\Fabio\Downloads\Miscellaneous\EXEs";
        string zipPath = @"C:\Users\Fabio\Downloads\Miscellaneous\Zips";
        string rarPath = @"C:\Users\Fabio\Downloads\Miscellaneous\Rars";

        // Ensure that the destination folders exist
        if (!Directory.Exists(msiPath))
            Directory.CreateDirectory(msiPath);
        if (!Directory.Exists(isoPath))
            Directory.CreateDirectory(isoPath);
        if (!Directory.Exists(exePath))
            Directory.CreateDirectory(exePath);
        if (!Directory.Exists(zipPath))
            Directory.CreateDirectory(zipPath);
        if (!Directory.Exists(rarPath))
            Directory.CreateDirectory(rarPath);

        string[] executables = Directory.GetFiles(sourcePath, "*.exe", SearchOption.TopDirectoryOnly)
            .Concat(Directory.GetFiles(sourcePath, "*.msi", SearchOption.TopDirectoryOnly))
            .Concat(Directory.GetFiles(sourcePath, "*.iso", SearchOption.TopDirectoryOnly))
            .ToArray();
        string[] compressedFiles = Directory.GetFiles(sourcePath, "*.zip", SearchOption.TopDirectoryOnly)
            .Concat(Directory.GetFiles(sourcePath, "*.rar", SearchOption.TopDirectoryOnly))
            .ToArray();

        foreach (string file in executables)
        {
            string fileName = Path.GetFileName(file);
            string exeDestinationPath = Path.Combine(exePath, fileName);
            string msiDestinationPath = Path.Combine(msiPath, fileName);
            string isoDestinationPath = Path.Combine(isoPath, fileName);
            if (file.EndsWith(".exe"))
                File.Move(file, exeDestinationPath);
            else if (file.EndsWith(".msi"))
                File.Move(file, msiDestinationPath);
            else if (file.EndsWith(".iso"))
                File.Move(file, isoDestinationPath);
        }
        foreach (string file in compressedFiles)
        {
            string fileName = Path.GetFileName(file);
            string destinationPath = Path.Combine(zipPath, fileName);
            string rarDestinationPath = Path.Combine(rarPath, fileName);
            if(file.EndsWith(".zip"))
                File.Move(file, destinationPath);
            else if (file.EndsWith(".rar"))
                File.Move(file, rarDestinationPath);
        }
    }
}