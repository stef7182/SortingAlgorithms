using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();

            List<int> list = new List<int>();

            for (int m = 10000; m > 0; m--)
            {
                list.Add(m);
            }
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            Console.WriteLine("NaiveSort:");
            list = controller.BubbleSort(list);
            //foreach (int k in list)
            //{
            //    Console.WriteLine(k);
            //}
            //Console.WriteLine("BubbleSort:");
            //list = controller.BubbleSort(list);
            //foreach (int k in list)
            //{
            //    Console.WriteLine(k);
            //}
        }
    }
}
