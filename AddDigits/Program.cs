using System;
using System.Collections.Generic;
using System.Linq;

namespace AddDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = new List<int>();
            int IntegerSum = 0;

            Console.WriteLine("Enter an integer");

            int userInput = Convert.ToInt32(Console.ReadLine());

            while (inputList.Count != 1)
            {
                while (userInput > 0)
                {
                    inputList.Add(userInput % 10);
                    userInput = userInput / 10;
                }

                foreach (var i in inputList)
                {
                    IntegerSum += i;
                }

                Console.WriteLine(IntegerSum);

                inputList.Clear();

                while (IntegerSum > 0)
                {
                    inputList.Add(IntegerSum % 10);
                    IntegerSum = IntegerSum / 10;
                }
                
                IntegerSum = 0;
            }
        }
    }
}
