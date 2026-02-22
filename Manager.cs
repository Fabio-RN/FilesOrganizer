using System.IO;
using System.Linq;
using System;
using System.Reflection.Metadata;
using Documents = Files_Organizer.DocumentFiles;
using Multimedia = Files_Organizer.MediaFiles;
using Programacion = Files_Organizer.ProgramationFiles;
using Miscelaneos = Files_Organizer.MiscellaneousFiles;


//TODO: Hacer que se ejecute el programa cada cierto tiempo, para que se mantenga organizado sin necesidad de abrirlo cada vez. (Posiblemente con un timer o algo asi)
//TODO: Traducir el programa al ingles, para que sea mas accesible a mas personas.

namespace Files_Organizer;

class Manager
{
    static void Main(string[] args)
    {
        Documents documents= new Documents();
        documents.OrganizeDocuments();
        Multimedia multimedia = new Multimedia();
        multimedia.OrganizeMedia();
        Programacion programacion = new Programacion();
        programacion.OrganizeProgramation();
        Miscelaneos miscelaneous = new Miscelaneos();
        miscelaneous.OrganizeMiscellaneous();
    }
}