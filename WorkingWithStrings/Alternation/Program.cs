using System.Text.RegularExpressions;

string pattern = "apple|orange";
string input = "I like apples and oranges.";

MatchCollection matches = Regex.Matches(input, pattern);
foreach(Match match in matches)
{
    Console.WriteLine(match.Value);
}