using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Numerics;
using System.Linq;

namespace Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<symbols>[\:]{2}|[\*]{2})(?<emoji>[A-Z][a-z]{2,})\1";
            string patternNumber = @"(?<number>\d.*?)";
            List<string> coolEmojis = new List<string>();
            string text = Console.ReadLine();
            MatchCollection matches = Regex.Matches(text, pattern);
            MatchCollection matchesNumber = Regex.Matches(text, patternNumber);
            BigInteger threshold = 1;
            foreach (Match matchNumber in matchesNumber)
            {
                if (BigInteger.Parse(matchNumber.Groups["number"].Value)>=0)
                {
                    threshold *= BigInteger.Parse(matchNumber.Groups["number"].Value);
                }
                
            }
            foreach (Match match in matches)
            {
                string emoji = match.Groups["emoji"].Value;
                int coolness = 0;
                for (int i = 0; i < emoji.Length; i++)
                {
                    coolness += emoji[i];
                }
                if (coolness >= threshold)
                {
                    coolEmojis.Add(match.Groups["symbols"].Value + match.Groups["emoji"].Value + match.Groups["symbols"].Value);
                }
            }
            Console.WriteLine($"Cool threshold: {threshold}");
            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");
            if (coolEmojis.Count >= 0)
            {
                foreach (var coolEmoji in coolEmojis)
                {
                    Console.WriteLine(coolEmoji);
                }
            }

        }
    }
}
