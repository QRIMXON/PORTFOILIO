using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
   
            public static void Main(string[] args)
            {
                ArrayList myAL = new ArrayList();
                double sum = 0;
                double large = 0;
                double small = 101;

                for (; ; )
                {
                    Console.WriteLine("Please enter Item Price or 0 to quit and get Total");

                    double itemPrice = Convert.ToDouble(Console.ReadLine());
                    if (itemPrice == 0)
                    {
                        break;
                    }
                    if (itemPrice < 0 )
                    {
                        Console.WriteLine("Invalid Entry");
                    }
                    else
                    {
                        myAL.Add(itemPrice);
                    }
                }
                foreach (double item in myAL)
                {
                    Console.WriteLine(item);
                    sum += item;
                    if (item > large)
                    { large = item; }
                    if (item < small)
                    { small = item; }
                }
                int result = myAL.Count;
                double average = sum / result;
            double taxRate = Convert.ToDouble(.08);
            double tax = (sum * taxRate);
            double total = sum + tax;
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            
                Console.WriteLine("number of items: {0}", result);
            Console.WriteLine("average price: {0:C}", average);
            Console.WriteLine("subtotal: {0:C}", sum);
            Console.WriteLine("tax: {0:C}", tax);
            Console.WriteLine("total: {0:C}", total);
                
               
                Console.WriteLine("");

            }
        }
    }

