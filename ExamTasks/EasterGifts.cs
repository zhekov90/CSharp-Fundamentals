using System;
using System.Collections.Generic;
using System.Linq;

namespace Easter_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            List<string> command = Console.ReadLine().Split().ToList();
            while (command[0]!="No")
            {
                if (command[0]=="OutOfStock")
                {
                    string name = command[1];
                    for (int i = 0; i < names.Count; i++)
                    {
                        if (names[i]==name)
                        {
                            names[i] = "None";
                        }
                    }
                }
                else if (command[0] == "Required")
                {
                    string name = command[1];
                    int index = int.Parse(command[2]);
                    if (index>=0 && index<names.Count)
                    {
                        names[index] = name;
                    }
                }
                else if (command[0] == "JustInCase")
                {
                    string name = command[1];
                    names[names.Count - 1] = name;
                }


                command = Console.ReadLine().Split().ToList();
            }
            if (command[0]=="No")
            {
                names.RemoveAll(gifts => gifts == "None");
                Console.WriteLine(string.Join(" ", names));
            }
            
        }
    }
}
