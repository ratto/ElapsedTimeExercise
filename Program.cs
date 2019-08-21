using System;
using ElapsedTimeExercise.Extensions;

namespace ElapsedTimeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2019, 8, 21, 10, 35, 51);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
