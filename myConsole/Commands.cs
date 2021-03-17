using System;
using System.Collections.Generic;
using System.Text;
using CommandLine;
using System.Threading;

namespace myConsole {
    public class ForFiles{
        public void IOcommand(string[] args){
            Parser.Default.ParseArguments<OptionsForFiles>(args)
                .WithParsed(Run)
                .WithNotParsed(HandleParseError);
        }

        private static void HandleParseError(IEnumerable<Error> errs){
            if (errs.IsVersion())
            {
                Console.WriteLine("Version Request");
                return;
            }

            if (errs.IsHelp())
            {
                Console.WriteLine("Help Request");
                return;
            }
            Console.WriteLine("Comando mal escrito.");
        }

        private static void Run(OptionsForFiles opts){
            Console.WriteLine("Parser success");
            Thread.Sleep(2000);
        }
    }
    
}
