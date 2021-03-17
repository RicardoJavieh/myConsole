using System.Collections.Generic;
using CommandLine;

namespace myConsole{
    class OptionsForFiles{
        [Option('p', "pathname", Required = false, HelpText = "Ruta de la carpeta.")]
        public string pathname { get; set; }

        [Option('m', "searchmask", Required = false, HelpText = "Filtra los archivos con una mascara especifica.")]
        public string searchmask { get; set; }

        [Option('s', "recursively", Required = false, HelpText = "Hace la funcion recursiva (Subdirectorios).")]
        public bool recursively { get; set; }
    }

    class OptionsReplace{
        [Option('o', "source", Required = true, HelpText = "Ruta de origen.")]
        public string source { get; set; }

        [Option('d', "destination", Required = true, HelpText = "Ruta de destino.")]
        public string destination { get; set; }

        [Option('a', "add", Required = false, HelpText = "Anade nuevos archivos en vez de remplazarlos.")]
        public bool add { get; set; }

        [Option('p', "confirmation", Required = false, HelpText = "Confirmacion antes de remplazar o anadir.")]
        public bool confirmation { get; set; }

        [Option('r', "readonlyreplace", Required = false, HelpText = "Remplaza los read-only y los archivos desprotegidos.")]
        public bool readonlyreplace { get; set; }

        [Option('s', "recursively", Required = false, HelpText = "Hace la funcion recursiva (Subdirectorios).")]
        public bool recursively { get; set; }
    }

    class OptionsUndelete
    {
        [Option('o', "source", Required = true, HelpText = "Ruta de origen.")]
        public string source { get; set; }

        [Option('a', "all", Required = false, HelpText = "Restaura todos los archivos")]
        public bool all { get; set; }

        [Option('l', "list", Required = false, HelpText = "Muestra una lista de los archivos que se pueden restaurar.")]
        public bool list { get; set; }
    }

    class OptionsXcopy
    {
        [Option('o', "source", Required = true, HelpText = "Ruta de origen.")]
        public string source { get; set; }

        [Option('d', "destination", Required = true, HelpText = "Ruta de destino.")]
        public string destination { get; set; }

        [Option('c', "ingore", Required = false, HelpText = "Ingora los errores.")]
        public bool ignore { get; set; }

        [Option('p', "confirmation", Required = false, HelpText = "Confirmacion antes de remplazar o anadir.")]
        public bool confirmation { get; set; }

        [Option('s', "recursively", Required = false, HelpText = "Hace la funcion recursiva (Subdirectorios).")]
        public bool recursively { get; set; }

        [Option('t', "structure", Required = false, HelpText = "Copia solo la estructura de carpetas.")]
        public bool structure { get; set; }
    }

    class OptionsDir
    {
        [Option('o', "source", Required = false, HelpText = "Ruta de origen.")]
        public string source { get; set; }

        [Option('q', "ownership", Required = false, HelpText = "Muestra los duenos de las carpetas.")]
        public bool ownership { get; set; }

        [Option('w', "wideformat", Required = false, HelpText = "Muestra una version extendida.")]
        public bool wideformat { get; set; }

        [Option('s', "recursively", Required = false, HelpText = "Hace la funcion recursiva (Subdirectorios).")]
        public bool recursively { get; set; }

        [Option('n', "longlist", Required = false, HelpText = "Muestra una lista con los nombres a la derecha de la pantalla.")]
        public bool longlist{ get; set; }
    }
}