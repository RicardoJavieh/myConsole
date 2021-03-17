using System;
using System.Collections.Generic;
using System.Text;
using CommandLine;
using System.Diagnostics;
using System.IO;

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
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C forfiles" 
                + (!opts.pathname.Equals("") ? "/P " + opts.pathname:"") 
                + (!opts.searchmask.Equals("")? "/M " + opts.searchmask:"") 
                + (opts.recursively.Equals(true)?"/S":"");
            process.StartInfo = startInfo;
            process.Start();
        }
    }
    
}
