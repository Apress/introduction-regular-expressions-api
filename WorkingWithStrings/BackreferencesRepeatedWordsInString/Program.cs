using System.Text.RegularExpressions;

string input = "the quick brown fox jumps over the lazy dog dog.";
string pattern = @"\b(\w+)\b\s+\1\b";

MatchCollection matches = Regex.Matches(input, pattern);
foreach (Match match in matches)
{
    Console.WriteLine("Match found: {0}", match.Value);
    //Output: Match found: dog dog
}