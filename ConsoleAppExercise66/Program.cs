using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ConsoleAppExercise66
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("apple");
            arrayList.Add("banana");
            arrayList.Add("dates");
            arrayList.Add("cherry");
            arrayList.Add("date");
            arrayList.Add("cranberry");
            Console.WriteLine("Total number of elements:" + arrayList.Count);
            bool containsDate = false;
            foreach (var item in arrayList)
            {
                if (item.ToString() == "date")
                {
                    containsDate = true;
                    break;
                }
            }
            Console.WriteLine("array list contains 'date' : "+ containsDate);
            arrayList.Insert(1, "fig");
            arrayList.Remove("banana");
            Console.WriteLine("updated ArrayList :");
            foreach(var item in arrayList)
            {
                Console.WriteLine(item);
                Console.ReadKey();
            }




        }
    }
}
