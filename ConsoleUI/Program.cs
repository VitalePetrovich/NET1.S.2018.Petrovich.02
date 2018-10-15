using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static TasksDay02.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1
            int num = InsertNumber(-4106, 22095, 4, 9);
            Console.WriteLine(num);
            
            Console.ReadKey();
        }
    }
}
