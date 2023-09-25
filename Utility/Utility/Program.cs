using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    internal class Program
    {
        static int Sum(params int[] nums)
        {
            int sum = 0;
            foreach (var i in nums) {
                sum += i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum());
            Console.WriteLine(Sum(12));
            Console.WriteLine(Sum(12,34));
            Console.WriteLine(Sum(12,34,56,76));
            Console.WriteLine(Sum(12,34,56,76,65,66,445,234,23));
            Console.WriteLine(Sum(12,34,56,76,65,66,445,234,23,56,5,3,3));
            
            Student student = new Student();
            student.id = 1;
            student.Name = "Tanvir";
           
        }
    }
}
