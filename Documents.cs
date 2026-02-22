using System.IO;
using System.Linq;
using System;

namespace Files_Organizer;

class DocumentFiles
{
    public void OrganizeDocuments()
    {
        string carpetaOrigen = @"C:\Users\Fabio\Downloads\";
        string carpetaDocumentos = @"C:\Users\Fabio\Downloads\Documentos\PDFs";
        string carpetaTxt = @"C:\Users\Fabio\Downloads\Documentos\TXTs";
        string carpetaDocx = @"C:\Users\Fabio\Downloads\Documentos\DOCXs";

        // Asegurarse de que las carpetas destino existan
        if (!Directory.Exists(carpetaDocumentos))
            Directory.CreateDirectory(carpetaDocumentos);
        if (!Directory.Exists(carpetaTxt))
            Directory.CreateDirectory(carpetaTxt);
        if (!Directory.Exists(carpetaDocx))
            Directory.CreateDirectory(carpetaDocx);    

        string[] pdfs = Directory.GetFiles(carpetaOrigen, "*.pdf", SearchOption.TopDirectoryOnly);
        string[] txt = Directory.GetFiles(carpetaOrigen, "*.txt", SearchOption.TopDirectoryOnly);
        string[] docx = Directory.GetFiles(carpetaOrigen, "*.docx", SearchOption.TopDirectoryOnly);

        foreach (string archivo in pdfs)
        {
            string nombreArchivo = Path.GetFileName(archivo);
            string rutaDestino = Path.Combine(carpetaDocumentos, nombreArchivo);

            File.Move(archivo, rutaDestino);
        }

        foreach (string archivo in txt)
        {
            string nombreArchivo = Path.GetFileName(archivo);
            string rutaDestino = Path.Combine(carpetaTxt, nombreArchivo);

            File.Move(archivo, rutaDestino);
        }

        foreach (string archivo in docx)
        {
            string nombreArchivo = Path.GetFileName(archivo);
            string rutaDestino = Path.Combine(carpetaDocx, nombreArchivo);

            File.Move(archivo, rutaDestino);
            Console.WriteLine($"Movido: {nombreArchivo}");
        }
    }
}