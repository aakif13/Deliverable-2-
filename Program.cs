/* Name: Aakif Lalani
  Date: 7/9/2023
  Assignment: create a C# application using two methods: 
       Method 1: Randomly populate an array with integers numbers between 10 and 50. The array length is a parameter for the method. 
       Method 2: Return the summation of all the elements of an array (the array is the parameter for this method)
*/

using System;

namespace Deliverable_2
{
    class Program
    {
        static int[] random_array(int array_len)
        {
            Random random = new Random();
            int[] MyArray = new int[array_len];
            for (int i = 0; i < array_len; i++)
            {
                MyArray[i] = random.Next(10, 50);
            }

            return MyArray;
        }

        static int sum(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum = sum + i;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int input = 0;

            while(true)
            {
                try
                {
                    Console.WriteLine("Enter an integer number between 5 and 15: ");
                    input = int.Parse(Console.ReadLine());

                    if (input >= 5 && input <= 15)
                    {
                        break;
                    }
                   
                }

                catch 
                {
                    Console.WriteLine("Invalid input. Please enter an integer value: ");
                }
            }

            int[] MyArray = random_array(input);

            Console.Write("The elements in the random array are: ");
            foreach (int i in MyArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("The sum is: " + sum(MyArray));


        }
    }
}