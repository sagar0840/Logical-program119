using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = new string[] { "Array", "swap", "Reverse", "fibonacci", "addition" };
            string[] arr2 = new string[5] { "suraj","sagar","nagesh","0","0"};
            
            foreach (string i in arr1)
            {
                Console.WriteLine(i);
            }
            //Array.Sort(arr1);
            Array.Copy(arr1, arr2,0 );
            Array.Clear(arr1, 5, 2);
            foreach (string i in arr2)
            {
                Console.WriteLine(i);
            }
        }
    }
    }

