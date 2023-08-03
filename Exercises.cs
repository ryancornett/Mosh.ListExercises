using System.Collections.Generic;

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

        public void Exercise3()
        {
            List<int> numberList = new();
            bool isUnique = true;
            bool checkNumberList(int input)
            {
                foreach (int number in numberList)
                {
                    if (number == input)
                    {
                        isUnique = false;
                    }
                }
                return isUnique;
            }

            Console.WriteLine("**************************\n* ENTER 5 UNIQUE NUMBERS *\n**************************");
            Console.Write("Enter an integer: ");
            int numberInput = Int32.Parse(Console.ReadLine());
            numberList.Add(numberInput);
            while (numberList.Count < 5)
            {
                Console.Write("Enter another integer: ");
                numberInput = Int32.Parse(Console.ReadLine());
                if (checkNumberList(numberInput))
                {
                    numberList.Add(numberInput);
                }
                else
                {
                    Console.WriteLine("ERROR");
                    isUnique = true;
                }
            }
            numberList.Sort();
            Console.WriteLine($"Your list of five unique numbers is: ");
            foreach (int number in numberList)
            {
                Console.Write($"{number} ");
            }
        }

        public void Exercise4()
        {
            List<int> numbersEntered = new List<int>();
            int userInt = 0;
            Console.WriteLine("Enter a number -OR- 'Quit' to exit");
            string userInput = Console.ReadLine();
            while (userInput != "Quit") 
            {
                userInt = Int32.Parse(userInput);
                if (!numbersEntered.Contains(userInt))
                {
                    numbersEntered.Add(userInt);
                    numbersEntered.Sort();
                }
                Console.WriteLine("You have entered " + ((numbersEntered.Count > 1) ? "these numbers:" : "this number:"));
                foreach (int number in numbersEntered) 
                {
                    Console.Write($"{number} ");
                }
                Console.WriteLine();
                Console.WriteLine("Enter another number (or 'Quit') : ");
                userInput = Console.ReadLine();
            }

        }

        public void Exercise5()
        {
            List<int> numbersEntered = new List<int>();
            bool longEnough = false;
            void CheckLength()
            {
                if (numbersEntered.Count >= 5)
                {
                    longEnough = true;
                }
            }
            
            Console.WriteLine("Supply a list of comma + space separated numbers (e.g 5, 1, 9, 2, 10):");
            string userInput = Console.ReadLine();
            foreach (var sub in userInput.Split(", "))
            {
                int num;
                if (int.TryParse(sub, out num))
                    numbersEntered.Add(num);
                CheckLength();
            }

            if (!longEnough)
            {
                Console.WriteLine("Invalid List");
                numbersEntered.Clear();
                Exercise5();
            }
            else
            {
                numbersEntered.Sort();
                Console.WriteLine($"The three smallest numbers you entered are: {numbersEntered[0]}, {numbersEntered[1]}, and {numbersEntered[2]}.");
            }
        }

    }
}
