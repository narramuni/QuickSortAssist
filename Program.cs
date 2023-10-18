using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortAssist
{
    public class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }
        static void runApp()
        {

            int[] marks = new int[5];
            marks[0] = 76;
            marks[1] = 82;
            marks[2] = 92;
            marks[3] = 96;
            marks[4] = 86;

            QuickSort.Sort(marks, 0, marks.Length - 1);


            Console.WriteLine("Sorted List of Marks in Ascending Order (Quick Sort):");
            foreach (var mark in marks)
            {
                Console.WriteLine($"Mark: {mark}");
            }

            Console.ReadLine();

            //QuickSort.Sort(marks, 0, marks.Length - 1);

            //Console.WriteLine("Sorted List of Marks in Ascending Order (Quick Sort):");
            //foreach (var mark in marks)
            //{
            //    Console.WriteLine($"Mark: {mark}");
            //}

            //Console.ReadLine();

        }
    }
}
