using System;
using NUnit.Framework;
using Cheroto.Core;

namespace Cheroto.Core.Tests
{
    [TestFixture]
    public class RGVerificationDigitCalculatorTests
    {
        [Test]
        [TestCase("46621468", "6")]
        [TestCase("10907440", "3")]
        [TestCase("45261246", "9")]
        public void ResultVerifier()
        {
            //Arrange
            var input = "20077193";
            var expectedOutput = "0";
            var verifier = new RGVerificationDigitCalculator();

            //Act
            var output = verifier.CalculateVerificationDigit(input);

            //Assert
            Assert.AreEqual(output, expectedOutput);

        }
    }
}
