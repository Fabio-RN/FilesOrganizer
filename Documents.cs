using System.IO;
using System.Linq;
using System;

namespace Files_Organizer;

class DocumentFiles
{
    public void OrganizeDocuments()
    {
        string sourcePath = @"C:\Users\Fabio\Downloads\";
        string documentsPath = @"C:\Users\Fabio\Downloads\Documents\PDFs";
        string txtPath = @"C:\Users\Fabio\Downloads\Documents\TXTs";
        string docxPath = @"C:\Users\Fabio\Downloads\Documents\DOCXs";

        // Ensure that the destination folders exist
        if (!Directory.Exists(documentsPath))
            Directory.CreateDirectory(documentsPath);
        if (!Directory.Exists(txtPath))
            Directory.CreateDirectory(txtPath);
        if (!Directory.Exists(docxPath))
            Directory.CreateDirectory(docxPath);    

        string[] pdfs = Directory.GetFiles(sourcePath, "*.pdf", SearchOption.TopDirectoryOnly);
        string[] txt = Directory.GetFiles(sourcePath, "*.txt", SearchOption.TopDirectoryOnly);
        string[] docx = Directory.GetFiles(sourcePath, "*.docx", SearchOption.TopDirectoryOnly);

        foreach (string file in pdfs)
        {
            string fileName = Path.GetFileName(file);
            string destinationPath = Path.Combine(documentsPath, fileName);

            File.Move(file, destinationPath);
        }

        foreach (string file in txt)
        {
            string fileName = Path.GetFileName(file);
            string destinationPath = Path.Combine(txtPath, fileName);

            File.Move(file, destinationPath);
        }

        foreach (string file in docx)
        {
            string fileName = Path.GetFileName(file);
            string destinationPath = Path.Combine(docxPath, fileName);

            File.Move(file, destinationPath);
            Console.WriteLine($"Moved: {fileName}");
        }
    }
}