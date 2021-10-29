using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;



namespace CreateNewListByValue
{

    public class Example
    {

        private static void printList(List<int> list)
        {

            string sep = "";
            foreach (var x in list)
            {
                Console.Write(sep);
                Console.Write(x);
                sep = ", ";
            }
            Console.WriteLine();


        }

        public static void splitListByKey(List<int> origin, List<int> beforevalue, List<int> aftervalue, int key)
        {

            int i = 0;
            for (; i < origin.Count; i++)
            {

                beforevalue.Add(origin[i]);
                if (origin[i] == key)
                {
                    break;
                }

            }
            i++;
            for (; i < origin.Count; i++)
            {
                aftervalue.Add(origin[i]);
            }
        }

        public static void Main()
        {

            List<int> origin = new List<int>();
            origin.Add(1);
            origin.Add(2);
            origin.Add(3);
            origin.Add(4);
            origin.Add(5);
            origin.Add(6);
            origin.Add(7);

            List<int> before = new List<int>();
            List<int> after = new List<int>();

            splitListByKey(origin, before, after, 4);
            printList(origin);
            printList(before);
            printList(after);

            Console.ReadKey();

        }
    }
}