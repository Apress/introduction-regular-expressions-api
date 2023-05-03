using System.Text.RegularExpressions;

string input = "The quick brown foox jumps over the lazy dog.";
string pattern = "[aeiou]";

MatchCollection matches = Regex.Matches(input, pattern);
foreach (Match match in matches)
{
    Console.WriteLine(match.Value);
}