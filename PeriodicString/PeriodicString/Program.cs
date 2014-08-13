using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PeriodicString
{
    class Program
    {

        static void Main(string[] args)
        {

            string str;
            int period;
            int replacement;

            Console.WriteLine("Enter String :   ");
            str = Console.ReadLine();

            Console.WriteLine("Enter period :   ");
            period = (int)Convert.ToInt32(Console.ReadLine());

            Program p = new Program();

            replacement = p.MinChanges(period, str);

            Console.WriteLine("No of replacement    :   " + replacement);
        }
      
        public int MinChanges(int maxPeriod, string acgt)
        {
            int r = 0;
            int period = maxPeriod;
            int[] arr = new int[maxPeriod];

            while (period != 0)
            {

                for (int j = 0; j < period; j++)
                {
                    for (int i = j; i < acgt.Length - period; i = i + period)
                    {

                        if (acgt[j] != acgt[i + period])
                        {
                            r++;

                        }
                    }

                }
                period--;
                arr[period] = r;

                r = 0;
            }
            Array.Sort(arr);

            return arr[0];

        }
    }

}