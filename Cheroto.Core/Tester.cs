using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheroto.Core
{
    class Tester
    {
        public static void Main(string args)
        {
            var cpf = "130506867";
            var verifier = new CPFVerificationDigitCalculator();
            Console.WriteLine(verifier.CalculateVerificationDigit(cpf));
        }
    }
}
