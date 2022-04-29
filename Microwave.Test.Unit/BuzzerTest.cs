using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Microwave.Classes.Boundary;
using Microwave.Classes.Interfaces;
using NSubstitute;

namespace Microwave.Test.Unit
{
    [TestFixture]
    public class BuzzerTest
    {
        private Buzzer uut;
        private IOutput output;

        [SetUp]
        public void Setup()
        {
            output = Substitute.For<Output>();
            uut = new Buzzer(output);
        }

        [Test]
        public void Buzzer_3BeepsCalled()
        {
            uut.ShortBeep();
            output.Received(3);
        }

        [Test]
        public void Buzzer_OutputCorrect()
        {
            uut.ShortBeep();
            output.Received(3).OutputLine(Arg.Is<string>(str => str.Contains("Beep!")));
        }
    }
}
