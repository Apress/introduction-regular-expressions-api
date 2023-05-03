using System.Text.RegularExpressions;

string input = "1233456789";
string pattern = @"(\d)\1+";

MatchCollection matches = Regex.Matches(input, pattern);
foreach(Match match in matches)
{
    Console.WriteLine("Match found: {0}", match.Value);
    //Output: Match found: 33
}