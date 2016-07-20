using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    public class CommandRecorder : CommandInvoker
    {
        private List<Command> commands = new List<Command>();

        public override void Execute(Command command)
        {
            base.Execute(command);
            commands.Add(command);
        }

        public void DeleteLastCommand()
        {
            if (commands.Count > 0)
            {
                commands.RemoveAt(commands.Count - 1);
            }
        }

        public IEnumerable<Command> GetCommands()
        {
            return commands;
        }

    }
}
