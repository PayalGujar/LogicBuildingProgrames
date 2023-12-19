using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*DONE
 3. generate your own function to satisfy the relationship between the inputs and outputs.
Your task is to create a function that, when fed the inputs below, produce the sample outputs shown.
Examples
832 ➞ 594
51 ➞ 36
7977 ➞ 180
1 ➞ 0
665 ➞ 99
149 ➞ 0

 */

namespace JijaInterviewQ
{
    internal class jijaQ4
    {
        public static int satifyRelationShip(int num)
        {
            int temp = num;
            int output = 0;
            int rev = 0;
            while(num!=0)
            {
                int rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
            }
            if (rev < temp)
            {
                output = temp - rev;
            }
            else
            {
                output = 0;
            }
            return output;

        }
        public static void Main(string[] args)
        {
            int num=satifyRelationShip(149);
            Console.WriteLine(num);
        }
    }
}
