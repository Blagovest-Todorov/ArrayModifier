using System;
using System.Linq;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrNums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray(); //Read aLine transform it to \int Arr

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] comds = line.Split( ); // split the string into substrings Arr by separator interval
                string command = comds[0];   // You receive here the Commands                                                           

                if (command == "swap")
                {
                    int baseIdx = int.Parse(comds[1]);       
                    int currIdx = int.Parse(comds[2]);

                    int firstNumber = arrNums[baseIdx];                    
                    arrNums[baseIdx] = arrNums[currIdx];
                    arrNums[currIdx] = firstNumber;
                }
                else if (command == "multiply")
                {
                    int baseIdx = int.Parse(comds[1]);        
                    int currIdx = int.Parse(comds[2]);
                    
                    int multiplication = arrNums[baseIdx] * arrNums[currIdx];
                    arrNums[baseIdx] = multiplication;
                }
                else //if command == "decrease"
                {
                    for (int i = 0; i < arrNums.Length; i++)
                    {
                        arrNums[i] = arrNums[i] - 1;
                    }
                }                
            }

            Console.WriteLine(string.Join(", ", arrNums));
        }
    }
}
