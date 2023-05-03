using System;
using System.Text.RegularExpressions;

string input = "My name is John, and I am 30 years old.";
string pattern = @"My name is ([A-Za-z]+), and I am (\d+) years old\.";

Match match = Regex.Match(input, pattern);
if (match.Success)
{
    string name = match.Groups[1].Value;
    int age = int.Parse(match.Groups[2].Value);
    Console.WriteLine("Name: {0}", name); // Output: Name: John
    Console.WriteLine("Age: {0}", age); // Output: Age: 30
} else {
    Console.WriteLine("No match found.");
}

string input1 = "The quick brown foox jumps over the lazy dog.";
string pattern1 = @"(quick)\s(brown)";

MatchCollection matches = Regex.Matches(input1, pattern1);
foreach (Match match1 in matches)
{
    Console.WriteLine(match1.Groups[0].Value);
    Console.WriteLine(match1.Groups[1].Value);
    Console.WriteLine(match1.Groups[2].Value);
}