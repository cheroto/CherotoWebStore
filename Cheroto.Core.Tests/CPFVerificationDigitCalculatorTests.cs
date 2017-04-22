using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Cheroto.Core;

namespace Cheroto.Core.Tests
{
    [TestFixture]
    class CPFVerificationDigitCalculatorTests
    {

        [Test]
        public void TestResult()
        {
            //Arrange
            var input = "130506867";
            var expectedOutput = "07";
            var verifier = new CPFVerificationDigitCalculator();

            //Act
            var output = verifier.CalculateVerificationDigit(input);

            //Assert
            Assert.AreEqual(expectedOutput, output);
        }


    }
}
