using System;
using System.Collections.Generic;
using CommandLine;
using System.Diagnostics;

namespace myConsole {
    public class ForFiles{
        public async void IOcommand(string[] args){
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
            string command = "/C forfiles"
                + (opts.pathname != null ? (" /P " + opts.pathname) : "")
                + (opts.searchmask != null ? (" /M " + opts.searchmask) : "")
                + (opts.recursively ? " /S" : "");
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = command;
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
        }
    }
    
}
