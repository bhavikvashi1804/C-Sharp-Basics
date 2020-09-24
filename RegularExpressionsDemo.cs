using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace C_Sharp
{
    class RegularExpressionsDemo
    {
        public static void ExplainRegularExpressions()
        {
            string pattern = @"\d";
            Regex regex1 = new Regex(pattern);
            string testString = "Hi there my number is 123456789";

            MatchCollection matches = regex1.Matches(testString);
            Console.WriteLine("Found {0} digits",matches.Count);

            foreach(Match hit in matches)
            {
                GroupCollection groupCollection = hit.Groups;
                Console.WriteLine("Found {0} at index {1}",groupCollection[0].Value,groupCollection[0].Index);
            }
        }
    }
}
