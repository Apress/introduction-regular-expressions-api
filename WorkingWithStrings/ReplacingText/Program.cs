using System.Text.RegularExpressions;

string pattern = "cat";
Regex regex = new Regex(pattern);
string result = regex.Replace("Quick brown cat.", "dog");
Console.WriteLine(result);