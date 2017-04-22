using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheroto.Core
{
    //TO IMPLEMENT
    public class CPFVerificationDigitCalculator : IVerificationDigitCalculator
    {
        public string CalculateVerificationDigit(string input)
        {
            var charList = input.ToCharArray();
            var numList = new List<int>();
            foreach (char c in charList)
            {
                numList.Add(Convert.ToInt32(c.ToString()));
            }

            int sum;
            int remainder;

            for (int i = 0; i < 2; i++)
            {
                sum = 0;
                for (int j = 0; j < numList.Count; j++)
                {
                    sum += (numList.Count + 1 - j) * numList[j];
                }
                remainder = (11 - sum % 11 > 9) ? 0 : 11 - sum % 11;
                numList.Add(remainder);                
            }
            var verificationDigits = numList[numList.Count - 2].ToString() + numList[numList.Count - 1].ToString();

            return verificationDigits;
        }

    }
}
