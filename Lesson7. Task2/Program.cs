using System;

namespace Lesson7._Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new[,]
            {
                {5, 2, 1},
                {7, 3, 1},
                {9, 5, 0}
            };

            for (int i = 0; i < array.GetLength(0); i++)
            {
                var maxValueInLine = array[i, 0];
                for (int j = 0; j < array.GetLength(1)-1; j++)
                {
                    if (array[i,j] < array[i,j+1])
                    {
                        maxValueInLine = array[i, j+1];
                    }
                }
                Console.WriteLine(maxValueInLine);
            }

        }
    }
}
