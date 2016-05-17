using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSum
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numberToCalculate = 1000000;
            int threadCount = Int32.Parse(Console.ReadLine());

            Thread[] threads = new Thread[threadCount];
            Range[] ranges = new Range[threadCount];

            for (int i = 0; i < threadCount; i++)
            {
                ranges[i] = new Range(numberToCalculate / threadCount * i, numberToCalculate / threadCount * (i + 1));
                threads[i] = new Thread(Sum);
                threads[i].Start(ranges[i]);

            }

            Thread.Sleep(1000);

            int sum = 0;
            for (int i = 0; i < threadCount; i++)
            {
                threads[i].Abort();
                sum += ranges[i].Result;
            }
            Console.WriteLine(sum);
        }



        public static void Sum(object range)
        {
            dynamic d = range;
            for (int i = d.Start; i < d.End; i++)
            {
                d.Result += i;
            }
        }

    }
}
