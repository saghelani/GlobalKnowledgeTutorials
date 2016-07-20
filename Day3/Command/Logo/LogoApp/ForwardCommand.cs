using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LogoLib;
using CommandPattern;

namespace LogoApp
{
    public class ForwardCommand : Command
    {
        private Turtle turtle;
        private int noOfTimes;

        public ForwardCommand(Turtle turtle, int noOfTimes)
        {
            this.turtle = turtle;
            this.noOfTimes = noOfTimes;
        }

        public override void Execute()
        {
            turtle.Forward(noOfTimes);
        }
    }
}
