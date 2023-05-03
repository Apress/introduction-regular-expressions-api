using System.Text.RegularExpressions;

string input = "The quick brown foox jumps over the lazy dog.";
string pattern = @"o{2}";

MatchCollection matches = Regex.Matches(input, pattern);
foreach (Match match in matches)
{
    Console.WriteLine(match.Value);
}