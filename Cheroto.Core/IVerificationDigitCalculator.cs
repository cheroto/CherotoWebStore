using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheroto.Core
{
    interface IVerificationDigitCalculator
    {
        string CalculateVerificationDigit(string input);
    }
}
