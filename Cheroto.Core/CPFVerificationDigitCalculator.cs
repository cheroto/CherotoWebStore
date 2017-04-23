using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheroto.Core
{
    public class CPFVerificationDigitCalculator : IVerificationDigitCalculator
    {
        public string CalculateVerificationDigit(string input)
        {
            //Create  Char list from string
            var charList = input.ToCharArray();

            //Create and initialize integer list
            var numList = new List<int>();

            //Fill numList with integers, char to string to int (dumb way)
            foreach (char c in charList)
            {
                numList.Add(Convert.ToInt32(c.ToString()));
            }

            
            int sum;
            int remainder;

            //Loop for verification Digit - Runs twice because CPF has two verification digits
            for (int i = 0; i < 2; i++)
            {
                sum = 0;

                //Loop to calculate sum 
                for (int j = 0; j < numList.Count; j++)
                {
                    //For example: 130506867 -> Sum = 1*10 + 3*9 + 0*8 + 5*7.......
                    sum += (numList.Count + 1 - j) * numList[j];
                }
                remainder = (11 - sum % 11 > 9) ? 0 : 11 - sum % 11;
                //Add remainder to list for second loop
                numList.Add(remainder);                
            }
            //Create string of last to items of list
            var verificationDigits = numList[numList.Count - 2].ToString() + numList[numList.Count - 1].ToString();

            return verificationDigits;
        }

    }
}
