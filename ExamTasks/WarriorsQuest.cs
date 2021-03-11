using System;
using System.Text;

namespace Warrior_s_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            string skill = Console.ReadLine();
            string[] command = Console.ReadLine().Split();

            while (command[0] != "For")
            {
                if (command.Length == 2 && command[1] == "Azeroth")
                {
                    return;
                }

                if (command[0] == "GladiatorStance")
                {
                    skill = skill.ToUpper();
                    Console.WriteLine(skill);
                }
                else if (command[0] == "DefensiveStance")
                {
                    skill = skill.ToLower();
                    Console.WriteLine(skill);
                }
                else if (command[0] == "Dispel")
                {
                    int index = int.Parse(command[1]);
                    char letter = char.Parse(command[2]);
                    if (index >= 0 && index < skill.Length)
                    {
                        // skill = skill.Replace(skill[index], letter);
                        
                        char[] temp = skill.ToCharArray();
                        temp[index] = letter;
                        skill = new string(temp);
                        Console.WriteLine("Success!");
                    }
                    else
                    {
                        Console.WriteLine("Dispel too weak.");
                    }

                }
                else if (command[0] == "Target")
                {
                    if (command[1] == "Change")
                    {
                        string substring1 = command[2];
                        string substring2 = command[3];
                        if (skill.Contains(substring1))
                        {
                            skill = skill.Replace(substring1, substring2);
                        }
                        Console.WriteLine(skill);
                    }
                    else if (command[1] == "Remove")
                    {
                        string substring1 = command[2];
                        if (skill.Contains(substring1))
                        {
                            {
                                skill = skill.Replace(substring1, "");
                            }
                        }
                        Console.WriteLine(skill);

                    }   
                    else
                    {
                        Console.WriteLine("Command doesn't exist!");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Command doesn't exist!");
                }

                command = Console.ReadLine().Split();
            }

        }
    }
}
