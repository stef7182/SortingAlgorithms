using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
  public  class Controller
    {
        public List<int> NaiveSort(List<int> list)
        {
           
            int n = list.Count;
            for(int i = 1; i < n; i++)
            {
                for(int j = 0; j < n - 1; j++)
                {
                    if(list[j] > list[j + 1])
                    {
                        //swap
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            return list;
        }

        public List<int> BubbleSort(List<int> list)
        {

            int n = list.Count;
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        //swap
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            return list;
        }


    }
}
