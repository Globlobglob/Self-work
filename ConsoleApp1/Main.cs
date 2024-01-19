using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main (string[] args)
        {
           Student s1 = new Student(4,4,5 , "Ivan", "Pupkin");
            s1.Print();
            s1.GetMark();
            Console.ReadLine();
            
        }

       
    }
}

