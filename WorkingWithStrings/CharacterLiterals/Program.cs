using System.Text.RegularExpressions;

string input = "Hello world!";
string pattern = "Hello";

Match match = Regex.Match(input, pattern);
if(match.Success)
{
    Console.WriteLine("Match found: {0}", match.Value);
} else {
    Console.WriteLine("No match found");
}
