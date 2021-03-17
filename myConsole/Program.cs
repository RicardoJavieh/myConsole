using System;
using System.Collections.Generic;
using CommandLine;

namespace myConsole
{
    class Program{
        static void Main(){
            string consoleInput;
            var commandTest;
            while (true){
                consoleInput = "";
                string[] commandArray = consoleInput.Split();
                if (commandArray[0] == "forfiles"){
                    commandTest = new ForFiles();
                }
                Console.Write(">> ");
                consoleInput = Console.ReadLine();
                commandTest.IOcommand(commandArray);
                commandTest = null;
            }
            
        }
    }
}
