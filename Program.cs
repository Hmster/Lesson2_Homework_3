using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Homework_3
{
    internal class Program
    {
        [Flags]
        internal enum WorkDays
        {
            monday = 1<<0,
            tuesday = 1<<1,
            wednesday = 1<<2,
            thursday = 1<<3,
            friday = 1<<4,
            saturday = 1<<5,
            sunday = 1<<6,
        }

        static void Main(string[] args)
        {
            WorkDays workDays1 = (WorkDays)0b_0011111;
            WorkDays workDays2 = (WorkDays)0b_0111111;
            WorkDays workDays3 = (WorkDays)0b_0111110;

            WorkDays allDays = (WorkDays)0b_1111111;

            Console.WriteLine($"shop1:     | {workDays1}");
            Console.WriteLine("-----------+----------------------------------------------------");
            Console.WriteLine($"shop2:     | {workDays2}");
            Console.WriteLine("-----------+----------------------------------------------------");
            Console.WriteLine($"shop3:     | {workDays3}");

            Console.ReadKey();

        }
    }
}
