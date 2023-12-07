using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingWikiExamples.DesignPatterns.Factory.Sorters
{
    internal class MergeSorter
    {
        //Merge sort is a sorting algorithm that sorts elements in order by 
        //diving them in two sub arrays of the original array, and then it 
        //goes it again until it can't no longer and it compare last pair 
        //which one is greater or less. The sorting will evetually reach
        //back to the top 
        public static int[] MergeSort(int[] array)
        {
            //assigns sub array based on what the middle is
            int middle = array.Length / 2;
            int[] leftArray = new int[middle];
            int[] rightArray = new int[array.Length - middle];

            for (int i = 0; i < middle; i++)
            {
                leftArray[i] = array[i];
            }

            for (int i = middle; i < array.Length; i++)
            {
                rightArray[i - middle] = array[i];
            }
            //Does the splitting in half again into smaller sub arrays
            leftArray = MergeSort(leftArray);
            rightArray = MergeSort(rightArray);
            //Finally Merges back the elements in the correct order
            return Merge(leftArray, rightArray);
        }

        public static int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    result[k] = left[i];
                    i++;
                }
                else
                {
                    result[k] = right[j];
                    j++;
                }

                k++;
            }

            while (i < left.Length)
            {
                result[k] = left[i];
                i++;
                k++;
            }

            while (j < right.Length)
            {
                result[k] = right[j];
                j++;
                k++;
            }

            return result;
        }
    }
}
