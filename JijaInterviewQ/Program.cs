/*
1>A word is alphabetically sorted if all of the letters in it are in consecutive alphabetical order. 
Some examples of alphabetically sorted words: abhors
(a is before b, b is before h, h is before o, etc.), ghost, accent, hoop. 
Create a function that takes in a sentence as input and returns true if there is at least 
one alphabetically sorted word inside that has a minimum length of 3.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JijaInterviewQ
{
    internal class Program
    {
        public static bool checkAlphabets(string str)
        {
            string[] strarr=str.Split(' ');
            bool flag = false;
            
            for(int i=0;i<strarr.Length;i++)
            {
                string str2 = strarr[i];
                char[] ch = strarr[i].ToCharArray();
                Array.Sort(ch);
                string str3=new string(ch);
                if(str2==str3 && str2.Length>=3)
                {
                    flag = true;
                }   
            }
            return flag;
        }
        static void Main(string[] args)
        {
            bool a=checkAlphabets("Your abhors is good");
            //bool a = checkAlphabets("Your taste is good");
            if (a)
            {
                Console.WriteLine("Contain word which are alphabetically sorted");
            }
            else
            {
                Console.WriteLine("Does not contain alphabetically sorted words");
            }


        }
    }
}
