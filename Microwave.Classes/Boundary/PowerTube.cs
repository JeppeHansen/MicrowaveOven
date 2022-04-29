using System;
using Microwave.Classes.Interfaces;

namespace Microwave.Classes.Boundary
{
    public class PowerTube : IPowerTube
    {
        private IOutput myOutput;

        private bool IsOn = false;

        //For configuring power tube power wattage 
        public int _config { get; }

        public PowerTube(IOutput output, int config)
        {
            myOutput = output;
            _config = config;
        }

        public void TurnOn(int power)
        {
            if (power < 1 || power > _config) //Power must be between zero and _config
            {
                throw new ArgumentOutOfRangeException("power", power, "Must be between 1 and the maximum wattage of this hardware configuration(incl.)");
            }

            if (IsOn)
            {
                throw new ApplicationException("PowerTube.TurnOn: is already on");
            }

            myOutput.OutputLine($"PowerTube works with {power}");
            IsOn = true;
        }

        public void TurnOff()
        {
            if (IsOn)
            {
                myOutput.OutputLine($"PowerTube turned off");
            }

            IsOn = false;
        }
    }
}