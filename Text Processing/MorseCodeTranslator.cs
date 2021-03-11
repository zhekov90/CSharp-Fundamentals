using System;
using System.Collections.Generic;
using System.Linq;

namespace Morse_Code_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> morse = Console.ReadLine().Split(" ", StringSplitOptions.None).ToList();
            List<string> text = new List<string>();

            for (int i = 0; i < morse.Count; i++)
            {
                    if (morse[i] == "|")
                    {
                        text.Add(" ");
                    }
                    else if (morse[i] == ".-")
                    {
                        text.Add("A");
                    }
                    else if (morse[i] == "-...")
                    {
                        text.Add("B");
                    }
                    else if (morse[i] == "-.-.")
                    {
                        text.Add("C");
                    }
                    else if (morse[i] == "-..")
                    {
                        text.Add("D");
                    }
                    else if (morse[i] == ".")
                    {
                        text.Add("E");
                    }
                    else if (morse[i] == "..-.")
                    {
                        text.Add("F");
                    }
                    else if (morse[i] == "--.")
                    {
                        text.Add("G");
                    }
                    else if (morse[i] == "....")
                    {
                        text.Add("H");
                    }
                    else if (morse[i] == "..")
                    {
                        text.Add("I");
                    }
                    else if (morse[i] == ".---")
                    {
                        text.Add("J");
                    }
                    else if (morse[i] == "-.-")
                    {
                        text.Add("K");
                    }
                    else if (morse[i] == ".-..")
                    {
                        text.Add("L");
                    }
                    else if (morse[i] == "--")
                    {
                        text.Add("M");
                    }
                    else if (morse[i] == "-.")
                    {
                        text.Add("N");
                    }
                    else if (morse[i] == "---")
                    {
                        text.Add("O");
                    }
                    else if (morse[i] == ".--.")
                    {
                        text.Add("P");
                    }
                    else if (morse[i] == "--.-")
                    {
                        text.Add("Q");
                    }
                    else if (morse[i] == ".-.")
                    {
                        text.Add("R");
                    }
                    else if (morse[i] == "...")
                    {
                        text.Add("S");
                    }
                    else if (morse[i] == "-")
                    {
                        text.Add("T");
                    }
                    else if (morse[i] == "..-")
                    {
                        text.Add("U");
                    }
                    else if (morse[i] == "...-")
                    {
                        text.Add("V");
                    }
                    else if (morse[i] == ".--")
                    {
                        text.Add("W");
                    }
                    else if (morse[i] == "-..-")
                    {
                        text.Add("X");
                    }
                    else if (morse[i] == "-.--")
                    {
                        text.Add("Y");
                    }
                    else if (morse[i] == "--..")
                    {
                        text.Add("Z");
                    }

            }

            Console.WriteLine(string.Join("", text));

        }
    }
}
