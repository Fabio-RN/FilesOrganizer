using System.IO;
using System.Linq;
using System;
using System.Reflection.Metadata;
using Documents = Files_Organizer.DocumentFiles;
using Media = Files_Organizer.MediaFiles;
using Programming = Files_Organizer.ProgrammingFiles;
using Miscellaneous = Files_Organizer.MiscellaneousFiles;


//TODO: Make the program run every certain time, so it stays organized without needing to open it every time. (Possibly with a timer or something like that)
//TODO: Translate the program to English, so it's more accessible to more people.

namespace Files_Organizer;

class Manager
{
    static void Main(string[] args)
    {
        Documents documents = new Documents();
        documents.OrganizeDocuments();
        Media media = new Media();
        media.OrganizeMedia();
        Programming programming = new Programming();
        programming.OrganizeProgramming();
        Miscellaneous miscellaneous = new Miscellaneous();
        miscellaneous.OrganizeMiscellaneous();
    }
}