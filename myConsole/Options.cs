using System.Collections.Generic;
using CommandLine;

namespace myConsole{
    class OptionsForFiles{
        [Option('p', "pathname", Required = false, HelpText = "Ruta de la carpeta.")]
        public string pathname { get; set; }

        [Option('m', "searchmask", Required = false, HelpText = "Filtra los archivos con una mascara especifica.")]
        public string searchmask { get; set; }

        [Option('s', "", Required = false, HelpText = "Hace la funcion recursiva (Subdirectorios).")]
        public bool recursively { get; set; }
    }

    class OptionsReplace{
    }
}