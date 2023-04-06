using System;

namespace OOP
{
    internal class Program
    {
        // 1

        static void Main(string[] args)
        {
            //        string test = "salam necesen";

            //        Console.WriteLine(test.WorkCount());
            //    }

            //}
            //public static class MyWork
            //{
            //    public static string WorkCount(this string value)
            //    {
            //        string result = "";

            //        string[] strings = value.Split(" ");



            //        for(int i = 0; i < strings.Length; i++)
            //        {
            //            char Upperword = char.ToUpper(strings[i][0]);

            //            result += $" {Upperword + strings[i].Substring(1)}";
            //        }
            //        return result;
            Console.WriteLine("The value of jan in month " +
                          "enum is " + (int)YearsDay.January);
            Console.WriteLine("The value of feb in month " +
                              "enum is " + (int)YearsDay.February);
            Console.WriteLine("The value of mar in month " +
                              "enum is " + (int)YearsDay.March);
            Console.WriteLine("The value of apr in month " +
                              "enum is " + (int)YearsDay.April);
            Console.WriteLine("The value of may in month " +
                              "enum is " + (int)YearsDay.May);
            Console.WriteLine("The value of jun in month " +
                              "enum is " + (int)YearsDay.June);
        }

        // 2

        enum Day
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        enum YearsDay
        {
            January,
            February,
            March,
            April,
            May,
            June
        }

        enum Tshort
        {
            Small,
            Medium,
            Large
        }
    }
}
