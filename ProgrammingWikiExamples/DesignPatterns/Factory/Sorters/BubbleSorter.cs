using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingWikiExamples.DesignPatterns.Factory.Sorters
{
    public class BubbleSorter
    {
        public int[] Sort(int[] array)
        {
            for(int i  = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                        
                    }
                }
            }

            return array;
        }
        
    }
}
