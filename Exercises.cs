using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh.ListExercises
{
    public class Exercises
    {
        public void Exercise1()
		{
            List<string> names = new List<string>();
            Console.WriteLine("Enter a name:");
            string userInput = Console.ReadLine();
            while (userInput != "")
            {
                names.Add(userInput);
                if (names.Count > 2)
                {
                    Console.WriteLine($"{names[0]}, {names[1]} and {(names.Count - 2)} others like your post.");
                }
                else if (names.Count == 2)
                {
                    Console.WriteLine($"{names[0]} and {names[1]} like your post.");
                }

                else
                {
                    Console.WriteLine($"{names[0]} likes your post.");
                }

                Console.WriteLine("Enter a name:");
                userInput = Console.ReadLine();
            }
        }
                public void Exercise2()
        {
            Console.Write("Enter your name: ");
            string yourName = Console.ReadLine();
            char[] arr = new char[yourName.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr.SetValue(yourName[i], i);
            }

            Array.Reverse(arr);
            string reversedName = new string(arr);
            Console.WriteLine(reversedName);
        }
		
    }
}
