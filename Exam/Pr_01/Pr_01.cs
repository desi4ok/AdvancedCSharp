using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class Pr_01
{
    static void Main()
    {
        string firstLine = Console.ReadLine();
        string[] strings = firstLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string input = Console.ReadLine();

        while (true)
        {
            if (input == "end")
            {
                break;
            }

            List<string> output = new List<string>();

            if (Regex.IsMatch(input, @"reverse from \d+ count \d+"))
            {
                List<string> stringsToReverse = new List<string>();

                var matchesRev = Regex.Match(input, @"reverse from (\d+) count (\d+)");

                string value1 = matchesRev.Groups[1].Value;
                string value2 = matchesRev.Groups[2].Value;

                int num1;
                int num2;
                if (!int.TryParse(value1, out num1) || !int.TryParse(value2, out num2))
                {
                    Console.WriteLine("Invalid input parameters.");
                }
                else
                {
                    num1 = int.Parse(value1);
                    num2 = int.Parse(value2);
                    if (num1 + num2 - 1 >= strings.Length)
                    {
                        Console.WriteLine("Invalid input parameters."); 
                    }
                    else
                    {
                        for (int i = num1; i < (num1 + num2); i++)
                        {
                            stringsToReverse.Add(strings[i]);
                        }
                        stringsToReverse.Reverse();

                        for (int j = 0; j < strings.Length; j++)
                        {
                            if (j >= num1 && j < num1 + num2)
                            {
                                output.Add(stringsToReverse[j - num1]);
                            }
                            else
                            {
                                output.Add(strings[j]);
                            }
                        }
                        Console.WriteLine("[" + string.Join<string>(", ", output) + "]");
                    }
                }
            }
            else if (Regex.IsMatch(input, @"sort from \d+ count \d+"))
            {
                List<string> stringsToSort = new List<string>();

                var matchesSort = Regex.Match(input, @"sort from (\d+) count (\d+)");

                string value1Sort = matchesSort.Groups[1].Value;
                string value2Sort = matchesSort.Groups[2].Value;

                int num1sort;
                int num2sort;
                if (!int.TryParse(value1Sort, out num1sort) || !int.TryParse(value2Sort, out num2sort))
                {
                    Console.WriteLine("Invalid input parameters.");
                }
                else
                {
                    num1sort = int.Parse(value1Sort);
                    num2sort = int.Parse(value2Sort);
                    if (num1sort + num2sort - 1 > strings.Length)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {
                        for (int i = num1sort; i < (num1sort + num2sort); i++)
                        {
                            stringsToSort.Add(strings[i]);
                        }
                        stringsToSort.Sort();

                        for (int j = 0; j < strings.Length; j++)
                        {
                            if (j >= num1sort && j < num1sort + num2sort)
                            {
                                output.Add(stringsToSort[j - num1sort]);
                            }
                            else
                            {
                                output.Add(strings[j]);
                            }
                        }
                        Console.WriteLine("[" + string.Join<string>(", ", output) + "]");
                    }
                }
            }
            else if (Regex.IsMatch(input, @"rollLeft \d+ times"))
            {
                List<string> stringsToRowLeft = new List<string>();

                var matches = Regex.Match(input, @"rollLeft (\d+) times");

                string value = matches.Groups[1].Value;
                
                int num;
                if (!int.TryParse(value, out num))
                {
                    Console.WriteLine("Invalid input parameters.");
                }
                else
                {
                    num = int.Parse(value);
                    string[] outputArray = new string[strings.Length];
                    for (int i = 0; i < strings.Length; i++)
                    {
                        int currentIndex = i;
                        
                        for (int moves = 0; moves < num; moves++)
                        {
                            
                            if (currentIndex == 0)
                            {
                                currentIndex = strings.Length - 1;
                            }
                            else
                            {
                                currentIndex--;
                            }
                        }
                        outputArray[currentIndex] = strings[i];
                    }
                    Console.WriteLine("[" + string.Join(", ", outputArray) + "]");
                    
                }
            }
            else if (Regex.IsMatch(input, @"rollRight \d+ times"))
            {
                List<string> stringsToRowLeft = new List<string>();

                var matches = Regex.Match(input, @"rollRight (\d+) times");

                string value = matches.Groups[1].Value;

                int num;
                if (!int.TryParse(value, out num))
                {
                    Console.WriteLine("Invalid input parameters.");
                }
                else
                {
                    num = int.Parse(value);
                    string[] outputArray = new string[strings.Length];
                    for (int i = 0; i < strings.Length; i++)
                    {
                        int currentIndex = i;

                        for (int moves = 0; moves < num; moves++)
                        {

                            if (currentIndex == strings.Length - 1)
                            {
                                currentIndex = 0;
                            }
                            else
                            {
                                currentIndex++;
                            }
                        }
                        outputArray[currentIndex] = strings[i];
                    }
                    Console.WriteLine("[" + string.Join(", ", outputArray) + "]");
                }
            }
            else
            {
                Console.WriteLine("Invalid input parameters.");
            }
            input = Console.ReadLine();
        }
    }
}

