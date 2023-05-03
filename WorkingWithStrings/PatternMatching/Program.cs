using System.Text.RegularExpressions;

string pattern = @"(\(\d{3}\)\s\d{3}-\d{4})";
// (xxx) xxx-xxxx or (123) 456-7890
Regex regex = new Regex(pattern);
Match match = regex.Match("My phone number is (123) 456-7890.");

if(match.Success)
{
    Console.WriteLine("Match found: {0}", match.Value);
} else {
    Console.WriteLine("No match found");
}

String newString = regex.Replace("My phone number is (123) 456-7890."
        , "(xxx) xxx-xxxx");
Console.WriteLine(newString);