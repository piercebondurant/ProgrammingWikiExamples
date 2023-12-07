using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingWikiExamples.DesignPatterns.Factory.Sorters
{
    internal class InsertionSorter
    {
        //Insertion sorting is an algorithm that would sort 
        //each element to its correct place at a time. The 
        //way it works is that it would first select the second 
        //element and compare with previous element which one
        //is greater. It would keep on checking previous elements
        //to properly place the selected element in the right order
        //for the iteration can continue.  
        public void InsertionSort(int[] arrayElements) 
        {
            int tempt; 

            for (int i = 1; i < arrayElements.Length; i++) 
            {
                tempt = arrayElements[i];
                for (int j = i - 1; j >= 0; ) 
                {
                    if (tempt < arrayElements[j])
                    {
                        arrayElements[j + 1] = arrayElements[j];
                        j--;
                        arrayElements[j + 1] = tempt;
                    }
                    else 
                    {
                        break;
                    }
                }
            }
        }
    }
}
