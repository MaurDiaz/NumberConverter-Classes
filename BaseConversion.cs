using System;

namespace Activity5._2._2
{
    class BaseConversion
    {
        private void Binary(int number)
        {
            string binary = "";
            int remainder;
            int decimalNumber = number;
            do{
                remainder = decimalNumber % 2;
                if(remainder != 0)
                {
                    binary += "1 ";
                } 
                else 
                {
                    binary += "0 ";
                }
                decimalNumber = decimalNumber/2;
            }while(decimalNumber > 0);
            Console.WriteLine($"Decimal value {number} in Binary is: {Reverse(binary)}");
        }
        private void Octal(int number)
        {
           string octal;
           int remainder, quotient;
           int decimalNumber = number;
           do{
               quotient = decimalNumber/8;
               remainder = number - quotient*8;
               octal += (string)

           }while(decimalNumber > 0);
        }
        private void PrintHexDigit(int number)
        {
            //ToDo
        }
        public void Print(int value, int nbase=10)
        {
            switch(nbase)
            {
                case 2: Binary(value);
                break;

                case 8: Octal(value);
                break;

                case 16: PrintHexDigit(value);
                break;

                default: Console.WriteLine($"Decimal value: {value}");
                break;
            }
        }
        private static string Reverse(string number)
        {
            string[] digits = number.TrimEnd().Split();
            string reversedString = "";

            for(int i = digits.Length-1; i >= 0; i--)
            {
                reversedString += digits[i];
            }
            return reversedString;
        }
    }    
}
