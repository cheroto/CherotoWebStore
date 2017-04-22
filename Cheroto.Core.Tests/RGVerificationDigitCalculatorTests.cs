﻿using System;
using NUnit.Framework;
using Cheroto.Core;

namespace Cheroto.Core.Tests
{
    [TestFixture]
    public class RGVerificationDigitCalculatorTests
    {
        [Test]
        public void ResultVerifier()
        {
            //Arrange
            var input = "20077193";
            var expectedOutput = "0";
            var verifier = new RGVerificationDigitCalculator();

            //Act
            var output = verifier.CalculateVerificationDigit(input);

            //Assert
            Assert.AreEqual(expectedOutput, output);

        }
    }
}
