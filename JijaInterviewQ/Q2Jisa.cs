using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JijaInterviewQ
{
    internal class Q2Jisa
    {
        public static bool CheckOrder(string str)
        {
            string[] strarr = str.Split(' ');
            bool flag = false;
            for (int i = 0; i < strarr.Length; i++)
            {
                string str2 = strarr[i];
                char[] ch = str2.ToCharArray();
                Array.Sort(ch);
                string str3 = new string(ch);
                if (str3 == str2 && str3.Length > 3)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public static void Main(string[] args)
        {
            bool a = CheckOrder("hoop");
            if (a)
            {
                Console.WriteLine("Order is correct");

            }
            else
            {
                Console.WriteLine("Order is not correct");
            }
        }
    }
}
