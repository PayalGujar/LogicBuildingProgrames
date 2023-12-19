using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 convert string into charArray and compare with original string and that wise convert
 */
/*
 Create a function that takes a string and returns the reversed string. However there's a few
rules to follow in order to make the challenge interesting:
The UPPERCASE/lowercase positions must be kept in the same order as the original string (see example #1 and #2).
Spaces must be kept in the same order as the original string (see example #3).
Examples
specialReverseString("Edabit") ➞ "Tibade"
specialReverseString("UPPER lower") ➞ "REWOL reppu"
specialReverseString("1 23 456") ➞ "6 54 321"
 */

/*namespace JijaInterviewQ
{
    internal class jijaQ2
    {
        public static string specialReverseString(string str)
        {
            char[] ch1 = str.ToCharArray();
            char[] result=new char[ch1.Length];
            for(int i=0; i<ch1.Length; i++)
            {
                if (ch1[i]==' ')
                {
                    result[i] = ' ';
                }
            }
            for(int i=ch1.Length-1; i>=0;i--)
            {
                for(int j=0; j<ch1.Length;j++)
                {
                    if (ch1[i]!=' ')
                    {
                        if (result[j] == ' ')
                        {
                            j--;
                        }
                        else
                        {
                            result[j] = ch1[i];
                            j--;
                        }
                    }
                }
            }


           
            
        }
        public static void Main(string[] args)
        {
            string str = specialReverseString("Tibade");
            Console.WriteLine(str);

        }
    }
}
*/