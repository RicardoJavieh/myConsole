using System;
using System.Collections.Generic;
using CommandLine;
using System.Diagnostics;

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
            string command = "/C forfiles"
                + (opts.pathname != null ? (" /p " + opts.pathname) : "")
                + (opts.searchmask != null ? (" /m " + opts.searchmask) : "")
                + (opts.recursively ? " /s" : "");
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

    public class replace
    {
        public void IOcommand(string[] args)
        {
            Parser.Default.ParseArguments<OptionsReplace>(args)
                .WithParsed(Run)
                .WithNotParsed(HandleParseError);
        }

        private static void HandleParseError(IEnumerable<Error> errs)
        {
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

        private static void Run(OptionsReplace opts)
        {
            string command = "/C replace"
                + (opts.source != null ? (" " + opts.source) : "")
                + (opts.destination != null ? (" " + opts.destination) : "")
                + (opts.add ? " /a" : "")
                + (opts.confirmation ? " /p" : "")
                + (opts.readonlyreplace ? " /r" : "")
                + (opts.recursively ? " /s" : "");
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

    public class undelete
    {
        public void IOcommand(string[] args)
        {
            Parser.Default.ParseArguments<OptionsUndelete>(args)
                .WithParsed(Run)
                .WithNotParsed(HandleParseError);
        }

        private static void HandleParseError(IEnumerable<Error> errs)
        {
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

        private static void Run(OptionsUndelete opts)
        {
            string command = "/C undelete"
                + (opts.source != null ? (" " + opts.source) : "")
                + (opts.all ? " /all" : "")
                + (opts.list ? " /list" : "");
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

    public class xcopy
    {
        public void IOcommand(string[] args)
        {
            Parser.Default.ParseArguments<OptionsXcopy>(args)
                .WithParsed(Run)
                .WithNotParsed(HandleParseError);
        }

        private static void HandleParseError(IEnumerable<Error> errs)
        {
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

        private static void Run(OptionsXcopy opts)
        {
            string command = "/C xcopy"
                + (opts.source != null ? (" " + opts.source) : "")
                + (opts.destination != null ? (" " + opts.destination) : "")
                + (opts.ignore ? " /c" : "")
                + (opts.confirmation ? " /p" : "")
                + (opts.recursively ? " /s" : "")
                + (opts.structure ? " /t" : "");
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

    public class dir {
        public void IOcommand(string[] args)
        {
            Parser.Default.ParseArguments<OptionsDir>(args)
                .WithParsed(Run)
                .WithNotParsed(HandleParseError);
        }

        private static void HandleParseError(IEnumerable<Error> errs)
        {
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

        private static void Run(OptionsDir opts)
        {
            string command = "/C dir"
                + (opts.source != null ? (" " + opts.source) : "")
                + (opts.ownership ? " /q" : "")
                + (opts.wideformat ? " /w" : "")
                + (opts.recursively ? " /s" : "")
                + (opts.longlist ? " /n" : "");
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
