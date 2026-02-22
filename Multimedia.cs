using System.IO;
using System.Linq;
using System;

namespace Files_Organizer;

class MediaFiles
{
    public void OrganizeMedia()
    {
        string carpetaOrigen = @"C:\Users\Fabio\Downloads\";

        //! CARPETAS DE VIDEOS PARA ORDENARLAS POR FORMATO
        string carpetaMp4 = @"C:\Users\Fabio\Downloads\Medios\Videos\MP4s";
        string carpetaAvi = @"C:\Users\Fabio\Downloads\Medios\Videos\AVIs";
        string carpetaMkv = @"C:\Users\Fabio\Downloads\Medios\Videos\MKVs";
        string carpetaMov = @"C:\Users\Fabio\Downloads\Medios\Videos\MOVs";
        string carpetaFlv = @"C:\Users\Fabio\Downloads\Medios\Videos\FLVs";
        string carpetaWmv = @"C:\Users\Fabio\Downloads\Medios\Videos\WMVs";

        //! CARPETAS DE IMAGENES PARA ORDENARLAS POR FORMATO
        string carpetaJpgs = @"C:\Users\Fabio\Downloads\Medios\Imagenes\JPGs";
        string carpetaPngs = @"C:\Users\Fabio\Downloads\Medios\Imagenes\PNGs";
        string carpetaGifs = @"C:\Users\Fabio\Downloads\Medios\Imagenes\GIFs";
        string carpetaIcos = @"C:\Users\Fabio\Downloads\Medios\Imagenes\ICOs";
        string carpetaWebp = @"C:\Users\Fabio\Downloads\Medios\Imagenes\WEBPs";
        string carpetaSvg = @"C:\Users\Fabio\Downloads\Medios\Imagenes\SVGs";
        string carpetaBmp = @"C:\Users\Fabio\Downloads\Medios\Imagenes\BMPs";
                
        //! CARPETAS DE AUDIO PARA ORDENARLAS POR FORMATO        
        string carpetaMp3 = @"C:\Users\Fabio\Downloads\Medios\Audios\MP3s";
        string carpetaWav = @"C:\Users\Fabio\Downloads\Medios\Audios\WAVs";
        string carpetaFlac = @"C:\Users\Fabio\Downloads\Medios\Audios\FLACs";
        string carpetaAac = @"C:\Users\Fabio\Downloads\Medios\Audios\AACs";
        string carpetaOgg = @"C:\Users\Fabio\Downloads\Medios\Audios\OGGs";
        string carpetaWma = @"C:\Users\Fabio\Downloads\Medios\Audios\WMAs";

        //! Revision de que las carpetas destino existan, si no, se crean
        if (!Directory.Exists(carpetaMp4))
            Directory.CreateDirectory(carpetaMp4);
        if (!Directory.Exists(carpetaAvi))
            Directory.CreateDirectory(carpetaAvi);
        if (!Directory.Exists(carpetaMkv))
            Directory.CreateDirectory(carpetaMkv);
        if (!Directory.Exists(carpetaMov))
            Directory.CreateDirectory(carpetaMov);
        if (!Directory.Exists(carpetaFlv))
            Directory.CreateDirectory(carpetaFlv);
        if (!Directory.Exists(carpetaWmv))
            Directory.CreateDirectory(carpetaWmv);
        
        if (!Directory.Exists(carpetaJpgs))
            Directory.CreateDirectory(carpetaJpgs);
        if (!Directory.Exists(carpetaPngs))
            Directory.CreateDirectory(carpetaPngs);
        if (!Directory.Exists(carpetaGifs))
            Directory.CreateDirectory(carpetaGifs);
        if (!Directory.Exists(carpetaIcos))
            Directory.CreateDirectory(carpetaIcos);
        if (!Directory.Exists(carpetaWebp))
            Directory.CreateDirectory(carpetaWebp);
        if (!Directory.Exists(carpetaSvg))
            Directory.CreateDirectory(carpetaSvg);
        if (!Directory.Exists(carpetaBmp))
            Directory.CreateDirectory(carpetaBmp);

        if (!Directory.Exists(carpetaMp3))
            Directory.CreateDirectory(carpetaMp3);
        if (!Directory.Exists(carpetaWav))
            Directory.CreateDirectory(carpetaWav);
        if (!Directory.Exists(carpetaFlac))
            Directory.CreateDirectory(carpetaFlac);
        if (!Directory.Exists(carpetaAac))
            Directory.CreateDirectory(carpetaAac);
        if (!Directory.Exists(carpetaOgg))
            Directory.CreateDirectory(carpetaOgg);
        if (!Directory.Exists(carpetaWma))
            Directory.CreateDirectory(carpetaWma);

        //! FORMATOS DE VIDEOS
        string[] videos = Directory.GetFiles(carpetaOrigen, "*.mp4", SearchOption.TopDirectoryOnly)
            .Concat(Directory.GetFiles(carpetaOrigen, "*.avi", SearchOption.TopDirectoryOnly))
            .Concat(Directory.GetFiles(carpetaOrigen, "*.mkv", SearchOption.TopDirectoryOnly))
            .Concat(Directory.GetFiles(carpetaOrigen, "*.mov", SearchOption.TopDirectoryOnly))
            .Concat(Directory.GetFiles(carpetaOrigen, "*.flv", SearchOption.TopDirectoryOnly))
            .Concat(Directory.GetFiles(carpetaOrigen, "*.wmv", SearchOption.TopDirectoryOnly))
            .ToArray();
        
        //! FORMATOS DE IMAGENES
        string[] imagenes = Directory.GetFiles(carpetaOrigen, "*.jpg", SearchOption.TopDirectoryOnly)
            .Concat(Directory.GetFiles(carpetaOrigen, "*.jpeg", SearchOption.TopDirectoryOnly))
            .Concat(Directory.GetFiles(carpetaOrigen, "*.png", SearchOption.TopDirectoryOnly))
            .Concat(Directory.GetFiles(carpetaOrigen, "*.gif", SearchOption.TopDirectoryOnly))
            .Concat(Directory.GetFiles(carpetaOrigen, "*.ico", SearchOption.TopDirectoryOnly))
            .Concat(Directory.GetFiles(carpetaOrigen, "*.webp", SearchOption.TopDirectoryOnly))
            .Concat(Directory.GetFiles(carpetaOrigen, "*.svg", SearchOption.TopDirectoryOnly))
            .Concat(Directory.GetFiles(carpetaOrigen, "*.bmp", SearchOption.TopDirectoryOnly))
            .ToArray();
        
        //! FORMATOS DE AUDIO
        string[] audios = Directory.GetFiles(carpetaOrigen, "*.mp3", SearchOption.TopDirectoryOnly)
            .Concat(Directory.GetFiles(carpetaOrigen, "*.wav", SearchOption.TopDirectoryOnly))
            .Concat(Directory.GetFiles(carpetaOrigen, "*.flac", SearchOption.TopDirectoryOnly))
            .Concat(Directory.GetFiles(carpetaOrigen, "*.aac", SearchOption.TopDirectoryOnly))
            .Concat(Directory.GetFiles(carpetaOrigen, "*.ogg", SearchOption.TopDirectoryOnly))
            .Concat(Directory.GetFiles(carpetaOrigen, "*.wma", SearchOption.TopDirectoryOnly))
            .ToArray();
        
        foreach (string archivo in videos)
        {
            string nombreArchivo = Path.GetFileName(archivo);
            string extension = Path.GetExtension(archivo).ToLower();
            string rutaDestino = "";
            if (extension == ".mp4")
                rutaDestino = Path.Combine(carpetaMp4, nombreArchivo);
            else if (extension == ".avi")
                rutaDestino = Path.Combine(carpetaAvi, nombreArchivo);
            else if (extension == ".mkv")
                rutaDestino = Path.Combine(carpetaMkv, nombreArchivo);
            else if (extension == ".mov")
                rutaDestino = Path.Combine(carpetaMov, nombreArchivo);
            else if (extension == ".flv")
                rutaDestino = Path.Combine(carpetaFlv, nombreArchivo);
            else if (extension == ".wmv")
                rutaDestino = Path.Combine(carpetaWmv, nombreArchivo);

            File.Move(archivo, rutaDestino);
        }        

        foreach (string archivo in imagenes)
        {
            string nombreArchivo = Path.GetFileName(archivo);
            string extension = Path.GetExtension(archivo).ToLower();
            string rutaDestino = "";

            if (extension == ".jpg" || extension == ".jpeg")
                rutaDestino = Path.Combine(carpetaJpgs, nombreArchivo);
            else if (extension == ".png")
                rutaDestino = Path.Combine(carpetaPngs, nombreArchivo);
            else if (extension == ".gif")
                rutaDestino = Path.Combine(carpetaGifs, nombreArchivo);
            else if (extension == ".ico")
                rutaDestino = Path.Combine(carpetaIcos, nombreArchivo);
            else if (extension == ".webp")
                rutaDestino = Path.Combine(carpetaWebp, nombreArchivo);
            else if (extension == ".svg")
                rutaDestino = Path.Combine(carpetaSvg, nombreArchivo);
            else if (extension == ".bmp")
                rutaDestino = Path.Combine(carpetaBmp, nombreArchivo);

            File.Move(archivo, rutaDestino);
            Console.WriteLine($"Movido: {nombreArchivo}");
        }

        foreach (string archivo in audios)
        {
            string nombreArchivo = Path.GetFileName(archivo);
            string extension = Path.GetExtension(archivo).ToLower();
            string rutaDestino = "";

            if (extension == ".mp3")
                rutaDestino = Path.Combine(carpetaMp3, nombreArchivo);
            else if (extension == ".wav")
                rutaDestino = Path.Combine(carpetaWav, nombreArchivo);
            else if (extension == ".flac")
                rutaDestino = Path.Combine(carpetaFlac, nombreArchivo);
            else if (extension == ".aac")
                rutaDestino = Path.Combine(carpetaAac, nombreArchivo);
            else if (extension == ".ogg")
                rutaDestino = Path.Combine(carpetaOgg, nombreArchivo);
            else if (extension == ".wma")
                rutaDestino = Path.Combine(carpetaWma, nombreArchivo);

            File.Move(archivo, rutaDestino);
        }
    }
}
