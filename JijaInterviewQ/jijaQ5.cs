using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Given a string, reverse all the words which have odd length. The even length words are not changed.
Examples
reverseOdd("Bananas") ➞ "sananaB"
reverseOdd("One two three four") ➞ "enO owt eerht four"
reverseOdd("Make sure uoy only esrever sdrow of ddo length")
➞ "Make sure you only reverse words of odd length"
 */

namespace JijaInterviewQ
{
    internal class jijaQ5
    {
        public static string ReverseOddLWords(string str)
        {
            string[] str2 = str.Split(' ');
            string[] str3=new string[str2.Length];
            string strnew = "";
            string reverse = "";
            for (int i=0;i<str2.Length; i++)
            {
                strnew = "";
                //int strlen = str2[i].Length;
                if (str2[i].Length % 2==0 ) 
                {
                   // strnew = strnew + str2[i];
                    continue;
                }
                else
                {
                    char[] ch = str2[i].ToCharArray();  
                    for(int j = ch.Length-1;j>=0; j--)
                    {
                        strnew = strnew + ch[j];
                    }
                   
                }
                str3[i] += strnew;
            }
            return string.Join("", str3);
        }
        public static void Main(string[] args)
        {
           string output= ReverseOddLWords("One two Three four");
            Console.WriteLine(output);
        }
    }
}
