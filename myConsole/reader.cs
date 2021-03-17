using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace myConsole {
    class poolCommands {
        dynamic jsonFile = JsonConvert.DeserializeObject("");
    }
    class ioConsole {
        Regex baseCommand = new Regex(@"^(command1|command2|command3)([\s]|$)[\w ./:'+-]*");
        private string commandRaw;
        public int setCommand(string auxCommand) {
            commandRaw = auxCommand;
            return 0;
        }
        public string getCommand(string auxCommand) {
            return auxCommand;
        }
        private int processCommand() {
            
            return 0;            
        }

    }
}
