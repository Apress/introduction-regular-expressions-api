using System.Text.RegularExpressions;
string pattern = @"(?<firstName>\w+)\s(?<lastName>\w+)";

Regex regex = new Regex(pattern);
Match match = regex.Match("John Doe");
if (match.Success)
{
    String firstName = match.Groups["firstName"].Value;
    String lastName = match.Groups["lastName"].Value;

    Console.WriteLine(firstName);
    Console.WriteLine(lastName);
} else {
    Console.WriteLine("No match found");
}
