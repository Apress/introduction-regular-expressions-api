using System.Text.RegularExpressions;

string input = "The quick brown fox jumps over the lazy dog.";
string pattern = @"\.";

MatchCollection matches = Regex.Matches(input, pattern);
foreach (Match match in matches)
{
    Console.WriteLine(match.Value);
}

string pattern1 = @"o+";
MatchCollection matches1 = Regex.Matches(input, pattern1);
foreach (Match match in matches1)
{
    Console.WriteLine(match.Value);
}

string pattern2 = @"o*";
MatchCollection matches2 = Regex.Matches(input, pattern2);
foreach (Match match in matches2)
{
    Console.WriteLine(match.Value);
}

string pattern3 = @"The\s?quick";
MatchCollection matches3 = Regex.Matches(input, pattern3);
foreach (Match match in matches3)
{
    Console.WriteLine(match.Value);
}