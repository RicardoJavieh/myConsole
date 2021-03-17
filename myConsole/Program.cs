using System;
using System.Collections.Generic;
using CommandLine;

namespace myConsole
{
    class Program{
        static void Main(){
            string consoleInput;
            dynamic commandTest;
            while (true){
                consoleInput = "";
                Console.Write(">> ");
                consoleInput = Console.ReadLine();
                string[] commandArray = consoleInput.Split();
                if (commandArray[0] == "forfiles"){
                    commandTest = new ForFiles();
                    commandTest.IOcommand(commandArray);
                }
                if (commandArray[0] == "replace")
                {
                    commandTest = new replace();
                    commandTest.IOcommand(commandArray);
                }
                if (commandArray[0] == "undelete")
                {
                    commandTest = new undelete();
                    commandTest.IOcommand(commandArray);
                }
                if (commandArray[0] == "xcopy")
                {
                    commandTest = new xcopy();
                    commandTest.IOcommand(commandArray);
                }
                if (commandArray[0] == "dir")
                {
                    commandTest = new dir();
                    commandTest.IOcommand(commandArray);
                }

                commandTest = null;
            }
            
        }
    }
}
