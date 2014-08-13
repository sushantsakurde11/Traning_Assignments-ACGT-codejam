//Name : Sushant Sakurde.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PeriodicString
{
    class Program
    {

        static void Main(string[] args)
        {

            string str="";
            int period;
            int replacement;
           
            Console.WriteLine("Enter number of string   :   ");
            int noOfString = (int)Convert.ToInt32(Console.ReadLine());
            string[] strarray = new string[noOfString];

            for (int i = 0; i < strarray.Length; i++)
            {
                Console.WriteLine("Enter String :   ");
                strarray[i] = Console.ReadLine();
               
            }
            Console.WriteLine("Enter period :   ");
            period = (int)Convert.ToInt32(Console.ReadLine());

            Program p = new Program();

            replacement = p.MinChanges(period, strarray);

            Console.WriteLine("No of replacement    :   " + replacement);
        }
        //public int MinChanges(int maxPeriod, string acgt)
        //{
        //    int r=0;

        //        for (int i = 0; i < acgt.Length - maxPeriod; i++)
        //        {

        //            if (acgt[i] != acgt[i + maxPeriod])
        //            {
        //                r++;

        //            }
        //        }
        //    return r;
        //}

        //public int MinChanges(int maxPeriod, string acgt)
        //{
        //    int r = 0;
        //    for (int j = 0; j < maxPeriod;j++)
        //        for (int i = j; i < acgt.Length - maxPeriod; i = i + maxPeriod)
        //    {

        //        if (acgt[j] != acgt[i + maxPeriod])
        //        {
        //            r++;

        //        }
        //    }
        //    return r;
        //}

        public int MinChanges(int maxPeriod, string[] str)
        {
            string acgt = "";
            int r = 0;
            int period = maxPeriod;
            int[] arr = new int[maxPeriod];

            for (int i = 0; i < str.Length; i++)
            {
               
                acgt += str[i];
            }

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
