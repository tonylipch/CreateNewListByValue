using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;


//

namespace CreateNewListByValue {


    public class List 
    {
  
        public int value{ get; set; }

        public override string ToString()
        {
            return "value: "+value ;
        }
     
    }




    class Findvalue {

        public void newList(List<List> originList , List<List> aftervalue ,List<List> beforevalue, int value) 
        {
            List list = new List();

            list.value = value;


 
            int i = 0;


            originList.Add(list);
         
            for (; i <originList.Count; )
            {


                originList.AddRange(aftervalue);

                if (list.value==value)
                {
                    break;

                }


            }

            for (; i<originList.Count;)
            {
                aftervalue.AddRange(originList);


                if (value == list.value)
                {
                    break;

                }


            }

            for (; i < aftervalue.Count;)
            {
                beforevalue.AddRange(aftervalue);


               


            }



        




    




        }

    }




    public class Example
    {
        public static void Main()
        {
         /*   // Create a list of parts.
            List<CreateList> list = new List<CreateList>();

            // Add parts to the list.

            list.Add(new CreateList {value= 1,value="Baba" });
            list.Add(new CreateList { value = 2, value = "Mama" });
            list.Add(new CreateList { value = 3, value = "Papa" });
            list.Add(new CreateList { value = 4, value = "Kaka" });
            list.Add(new CreateList { value = 5, value = "Taka" });

          



            // Write out the parts in the list. This will call the overridden ToString method
            // in the Part class.
            Console.WriteLine();
            foreach (CreateList li in list)
            {
                Console.WriteLine(li);

            }

            Console.WriteLine();




            

   

*/









        }
    }
