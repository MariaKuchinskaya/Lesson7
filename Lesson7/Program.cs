using System;

namespace Lesson7
{
    internal class Program
    {
        private static void Main()
        {
            var array = new[] {5, 1, 8, 0};

            foreach (var t in array)
            {
                Console.WriteLine(t);
            }

            for (var i = 0; i < array.Length-1; i++)
            {
                for (var j = 0; j < array.Length-1; j++)
                {
                     if (array[j] < array[j + 1])
                     {
                         (array[j], array[j + 1]) = (array[j + 1], array[j]);
                     }
                    
                }
            }

            foreach (var t in array)
            {
                Console.WriteLine(t);
            }
        }
    }
}
