using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace RemoveHeaders
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string[]> listArray = new List<string[]>();

            string[] array1 = { "ABC", "DEF", "GHI" };
            string[] array2 = { "ABC", "KLM", "NOP" };
            string[] array3 = { "ABC", "QRS", "STU" };
            string[] array4 = { "ABC", "VXY", "Z12", "345" };

            listArray.Add(array1);
            listArray.Add(array2);
            listArray.Add(array3);
            listArray.Add(array4);

            List<string> newList = RemoveHeaders(listArray);

            foreach(string s in newList)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }

        public static List<string> RemoveHeaders(List<string[]> listArray)
        {
            List<string> newString = new List<string>();

            var newArray = listArray.ToArray();

            var solutionToArray = listArray.SelectMany(i => i).Distinct().ToArray();

            var solutionToList = listArray.SelectMany(i => i).Distinct().ToList();

            return solutionToList;
        }
    }
}
