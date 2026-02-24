using System.IO;
using System.Linq;
using System;

namespace Files_Organizer;

class MediaFiles
{
    public void OrganizeMedia()
    {
        string sourcePath = @"C:\Users\Fabio\Downloads\";

        //! VIDEO FOLDERS TO ORGANIZE THEM BY FORMAT
        string mp4Path = @"C:\Users\Fabio\Downloads\Media\Videos\MP4s";
        string aviPath = @"C:\Users\Fabio\Downloads\Media\Videos\AVIs";
        string mkvPath = @"C:\Users\Fabio\Downloads\Media\Videos\MKVs";
        string movPath = @"C:\Users\Fabio\Downloads\Media\Videos\MOVs";
        string flvPath = @"C:\Users\Fabio\Downloads\Media\Videos\FLVs";
        string wmvPath = @"C:\Users\Fabio\Downloads\Media\Videos\WMVs";

        //! IMAGE FOLDERS TO ORGANIZE THEM BY FORMAT
        string jpgPath = @"C:\Users\Fabio\Downloads\Media\Images\JPGs";
        string pngPath = @"C:\Users\Fabio\Downloads\Media\Images\PNGs";
        string gifPath = @"C:\Users\Fabio\Downloads\Media\Images\GIFs";
        string icoPath = @"C:\Users\Fabio\Downloads\Media\Images\ICOs";
        string webpPath = @"C:\Users\Fabio\Downloads\Media\Images\WEBPs";
        string svgPath = @"C:\Users\Fabio\Downloads\Media\Images\SVGs";
        string bmpPath = @"C:\Users\Fabio\Downloads\Media\Images\BMPs";
                
        //! AUDIO FOLDERS TO ORGANIZE THEM BY FORMAT        
        string mp3Path = @"C:\Users\Fabio\Downloads\Media\Audio\MP3s";
        string wavPath = @"C:\Users\Fabio\Downloads\Media\Audio\WAVs";
        string flacPath = @"C:\Users\Fabio\Downloads\Media\Audio\FLACs";
        string aacPath = @"C:\Users\Fabio\Downloads\Media\Audio\AACs";
        string oggPath = @"C:\Users\Fabio\Downloads\Media\Audio\OGGs";
        string wmaPath = @"C:\Users\Fabio\Downloads\Media\Audio\WMAs";

        //! Check if the destination folders exist, if not, create them
        if (!Directory.Exists(mp4Path))
            Directory.CreateDirectory(mp4Path);
        if (!Directory.Exists(aviPath))
            Directory.CreateDirectory(aviPath);
        if (!Directory.Exists(mkvPath))
            Directory.CreateDirectory(mkvPath);
        if (!Directory.Exists(movPath))
            Directory.CreateDirectory(movPath);
        if (!Directory.Exists(flvPath))
            Directory.CreateDirectory(flvPath);
        if (!Directory.Exists(wmvPath))
            Directory.CreateDirectory(wmvPath);
        
        if (!Directory.Exists(jpgPath))
            Directory.CreateDirectory(jpgPath);
        if (!Directory.Exists(pngPath))
            Directory.CreateDirectory(pngPath);
        if (!Directory.Exists(gifPath))
            Directory.CreateDirectory(gifPath);
        if (!Directory.Exists(icoPath))
            Directory.CreateDirectory(icoPath);
        if (!Directory.Exists(webpPath))
            Directory.CreateDirectory(webpPath);
        if (!Directory.Exists(svgPath))
            Directory.CreateDirectory(svgPath);
        if (!Directory.Exists(bmpPath))
            Directory.CreateDirectory(bmpPath);

        if (!Directory.Exists(mp3Path))
            Directory.CreateDirectory(mp3Path);
        if (!Directory.Exists(wavPath))
            Directory.CreateDirectory(wavPath);
        if (!Directory.Exists(flacPath))
            Directory.CreateDirectory(flacPath);
        if (!Directory.Exists(aacPath))
            Directory.CreateDirectory(aacPath);
        if (!Directory.Exists(oggPath))
            Directory.CreateDirectory(oggPath);
        if (!Directory.Exists(wmaPath))
            Directory.CreateDirectory(wmaPath);

        //! VIDEO FORMATS
        string[] videoFiles = Directory.GetFiles(sourcePath, "*.mp4", SearchOption.TopDirectoryOnly)
            .Concat(Directory.GetFiles(sourcePath, "*.avi", SearchOption.TopDirectoryOnly))
            .Concat(Directory.GetFiles(sourcePath, "*.mkv", SearchOption.TopDirectoryOnly))
            .Concat(Directory.GetFiles(sourcePath, "*.mov", SearchOption.TopDirectoryOnly))
            .Concat(Directory.GetFiles(sourcePath, "*.flv", SearchOption.TopDirectoryOnly))
            .Concat(Directory.GetFiles(sourcePath, "*.wmv", SearchOption.TopDirectoryOnly))
            .ToArray();
        
        //! IMAGE FORMATS
        string[] imageFiles = Directory.GetFiles(sourcePath, "*.jpg", SearchOption.TopDirectoryOnly)
            .Concat(Directory.GetFiles(sourcePath, "*.jpeg", SearchOption.TopDirectoryOnly))
            .Concat(Directory.GetFiles(sourcePath, "*.png", SearchOption.TopDirectoryOnly))
            .Concat(Directory.GetFiles(sourcePath, "*.gif", SearchOption.TopDirectoryOnly))
            .Concat(Directory.GetFiles(sourcePath, "*.ico", SearchOption.TopDirectoryOnly))
            .Concat(Directory.GetFiles(sourcePath, "*.webp", SearchOption.TopDirectoryOnly))
            .Concat(Directory.GetFiles(sourcePath, "*.svg", SearchOption.TopDirectoryOnly))
            .Concat(Directory.GetFiles(sourcePath, "*.bmp", SearchOption.TopDirectoryOnly))
            .ToArray();
        
        //! AUDIO FORMATS
        string[] audioFiles = Directory.GetFiles(sourcePath, "*.mp3", SearchOption.TopDirectoryOnly)
            .Concat(Directory.GetFiles(sourcePath, "*.wav", SearchOption.TopDirectoryOnly))
            .Concat(Directory.GetFiles(sourcePath, "*.flac", SearchOption.TopDirectoryOnly))
            .Concat(Directory.GetFiles(sourcePath, "*.aac", SearchOption.TopDirectoryOnly))
            .Concat(Directory.GetFiles(sourcePath, "*.ogg", SearchOption.TopDirectoryOnly))
            .Concat(Directory.GetFiles(sourcePath, "*.wma", SearchOption.TopDirectoryOnly))
            .ToArray();
        
        foreach (string file in videoFiles)
        {
            string fileName = Path.GetFileName(file);
            string extension = Path.GetExtension(file).ToLower();
            string destinationPath = "";
            if (extension == ".mp4")
                destinationPath = Path.Combine(mp4Path, fileName);
            else if (extension == ".avi")
                destinationPath = Path.Combine(aviPath, fileName);
            else if (extension == ".mkv")
                destinationPath = Path.Combine(mkvPath, fileName);
            else if (extension == ".mov")
                destinationPath = Path.Combine(movPath, fileName);
            else if (extension == ".flv")
                destinationPath = Path.Combine(flvPath, fileName);
            else if (extension == ".wmv")
                destinationPath = Path.Combine(wmvPath, fileName);

            File.Move(file, destinationPath);
        }        

        foreach (string file in imageFiles)
        {
            string fileName = Path.GetFileName(file);
            string extension = Path.GetExtension(file).ToLower();
            string destinationPath = "";

            if (extension == ".jpg" || extension == ".jpeg")
                destinationPath = Path.Combine(jpgPath, fileName);
            else if (extension == ".png")
                destinationPath = Path.Combine(pngPath, fileName);
            else if (extension == ".gif")
                destinationPath = Path.Combine(gifPath, fileName);
            else if (extension == ".ico")
                destinationPath = Path.Combine(icoPath, fileName);
            else if (extension == ".webp")
                destinationPath = Path.Combine(webpPath, fileName);
            else if (extension == ".svg")
                destinationPath = Path.Combine(svgPath, fileName);
            else if (extension == ".bmp")
                destinationPath = Path.Combine(bmpPath, fileName);

            File.Move(file, destinationPath);
            Console.WriteLine($"Moved: {fileName}");
        }

        foreach (string file in audioFiles)
        {
            string fileName = Path.GetFileName(file);
            string extension = Path.GetExtension(file).ToLower();
            string destinationPath = "";

            if (extension == ".mp3")
                destinationPath = Path.Combine(mp3Path, fileName);
            else if (extension == ".wav")
                destinationPath = Path.Combine(wavPath, fileName);
            else if (extension == ".flac")
                destinationPath = Path.Combine(flacPath, fileName);
            else if (extension == ".aac")
                destinationPath = Path.Combine(aacPath, fileName);
            else if (extension == ".ogg")
                destinationPath = Path.Combine(oggPath, fileName);
            else if (extension == ".wma")
                destinationPath = Path.Combine(wmaPath, fileName);

            File.Move(file, destinationPath);
        }
    }
}
