using System;
using System.Collections.Generic;
using CommandLine;

namespace myConsole
{
    class Program{
        static void Main(){
            ForFiles commandTest = new ForFiles();
            commandTest.IOcommand("forfiles -p B:\\Descargas\\Demo.CS".Split());
        }
    }
}
