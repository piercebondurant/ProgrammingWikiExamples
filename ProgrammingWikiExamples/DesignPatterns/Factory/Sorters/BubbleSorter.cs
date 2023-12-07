using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingWikiExamples.DesignPatterns.Factory.Sorters
{
    internal class BubbleSorter
    {
        //A bubble sort is a sorting algorithm that swamps elements that are next to each other 
        //each time it iterates through the list until it's in the correct order. The reason for the 
        //name is that either the larger or smaller elements would "bubble" to the top of the list.
        public void BubbleSorting(int[] arrayElements) 
        {
            int tempt; 

            for (int j = 0; j < arrayElements.Length; j++) 
            {
                //To fulfill a bubble sort it's necessary to have
                //another loop since this sorting algorithm will
                //iterate multiple times until the order is correct.
                //In other words, it would reset back at the beginning and
                //do it again until it's done.
                for (int i = 0; i < arrayElements.Length; i++) 
                {
                    if (arrayElements[i] > arrayElements[i + 1]) 
                    {
                        //Temporarily hold next element's data
                        //so each element can swamp in the correctly
                        //place depending if first element is greater
                        //than the next element. So the second element
                        //will be first and the first will be second.
                        tempt = arrayElements[i + 1];
                        arrayElements[i + 1] = arrayElements[i];
                        arrayElements[i] = tempt;
                    }
                }
            }
        }
    }
}
