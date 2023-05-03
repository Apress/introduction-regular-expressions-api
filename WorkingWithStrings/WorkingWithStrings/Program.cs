string myString = "Hello, World!";
Console.WriteLine(myString);

string name = "John";
string greeting = $"Hello, {name}!";
Console.WriteLine(greeting);

// returns the length of the string
int length = myString.Length;
Console.WriteLine(length);

// converts the string to uppercase
string upperCase = myString.ToUpper();
Console.WriteLine(upperCase);

// converts the string to lowercase
string lowerCase = myString.ToLower();
Console.WriteLine(lowerCase);

// checks if the string contains 
// a specified substring
bool contains = myString.Contains("World");
Console.WriteLine(contains);

// splits the string into an array of substrings, 
// based on a specified separator
string[] words = myString.Split(',');
Console.WriteLine(words[0]);
Console.WriteLine(words[1]);

// removes any leading or trailing whitespace 
// from the string
string myString1 = "    Hello, World!   ";
string trimmed = myString1.Trim();
Console.WriteLine(trimmed);