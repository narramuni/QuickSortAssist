using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortAssist
{
    public class QuickSort
    {

       
            public static void Sort(int[] arr, int low, int high)
            {
                if (low < high)
                {
                    int pivot = Partition(arr, low, high);
                    if (pivot > 1)
                    {
                        Sort(arr, low, pivot - 1);
                    }
                    if (pivot + 1 < high)
                    {
                        Sort(arr, pivot + 1, high);
                    }
                }
            }

            private static int Partition(int[] arr, int low, int high)
            {
                int pivot = arr[low];
                while (true)
                {
                    while (arr[low] < pivot)
                    {
                        low++;
                    }

                    while (arr[high] > pivot)
                    {
                        high--;
                    }

                    if (low < high)
                    {
                        Swap(arr, low, high);
                    }
                    else
                    {
                        return high;
                    }
                }
            }

            private static void Swap(int[] arr, int left, int right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
            }
        }
    

}
