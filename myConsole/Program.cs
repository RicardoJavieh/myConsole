using System;
using System.Collections.Generic;
using CommandLine;

namespace myConsole
{
    class Program{
        static void Main(){
            ForFiles commandTest = new ForFiles();
            String[] array = new String[] { "forfiles -p" };
            Console.WriteLine("hehe");
            commandTest.IOcommand(array);
        }
    }
}
