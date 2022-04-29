using System;
using System.Collections.Generic;
using System.Text;
using Microwave.Classes.Interfaces;

namespace Microwave.Classes.Boundary
{
    public class Buzzer
    {
        private IOutput myOutput;

        public Buzzer(IOutput output)
        {
            myOutput = output;

        }
        void ShortBeep()
        {
            for (int i = 0; i < 3; i++)
            myOutput.OutputLine("Beep!");
            
        }
    }
}
