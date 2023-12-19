using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JijaInterviewQ
{
    internal class TrainProblem
    {
        public static int FindSeat(int capacity, int[] carriage)
        {
            int temp = 0;
            for(int i=0;i<carriage.Length;i++)
            {
                int value = carriage[i];
                double per=((double)value/capacity)*100;
                //double per = ((double)carriage[i]/capacity)*100;
                if(per <= 50)
                {
                    temp = i;   
                }
            }

            if(temp>1)
            {
                return temp;
            }
            else
            {
                return -1;
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(FindSeat(20, new int[] { 3, 5, 4, 2 }));
            Console.WriteLine(FindSeat(200, new int[] { 35, 23, 18, 10, 40 }));
        }
    }
}
