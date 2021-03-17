using System.Collections.Generic;
using CommandLine;

namespace myConsole{
    class OptionsForFiles{
        [Option('p', "pathname", Required = true, HelpText = "Ruta de la carpeta.")]
        public IEnumerable<string> pathname { get; set; }

        [Option('m', "searchmask", Required = false, HelpText = "Filtra los archivos con una mascara especifica.")]
        public IEnumerable<string> serachmask { get; set; }

        [Option('s', "", Required = false, HelpText = "Hace la funcion recursiva (Subdirectorios).")]
        public IEnumerable<string> recursively { get; set; }
    }

    class OptionsReplace{
    }
}