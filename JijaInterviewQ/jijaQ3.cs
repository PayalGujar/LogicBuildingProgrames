using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*DONE
 1. Given a string, create a function to reverse the case. 
 All lower-cased letters should be upper-cased, and vice versa.
Examples
reverseCase("Happy Birthday") ➞ "hAPPY Birthday"
reverseCase("MANY THANKS") ➞ "many thanks"
reverseCase("sPoNtAnEoUs") ➞ "SpOnTaNeOuS"
 */

namespace JijaInterviewQ
{
    internal class jijaQ3
    {
        public static string ReverseCase(string str)
        {
            char[] ch=str.ToCharArray();
            string str1 = "";
            for (int i = 0; i < ch.Length; i++)
            {
                char c= ch[i];
                if(char.IsLower(c))
                {
                  str1=str1 + char.ToUpper(c);
                    
                }
                else if(char.IsUpper(c))
                {
                   str1 = str1 + char.ToLower(c);
                }
                else if(c==' ')
                {
                    str1= str1 + ' ';
                }
            }
            return str1;

        }
        public static void Main(string[] args)
        {
            string str = ReverseCase("HAPPY birthday");
            Console.WriteLine(str);
        }
    }
}
