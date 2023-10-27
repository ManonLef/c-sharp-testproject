Console.WriteLine("a" == "a"); // true
Console.WriteLine("a" == "A"); // false
Console.WriteLine(1 == 2); // false

string myValue = "a";
Console.WriteLine("a" == myValue); // true

// comparison operators
string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1 == value2); // false
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower()); //true

// methods that return a boolean
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox")); // true
Console.WriteLine(pangram.Contains("cow")); // false

// logical negation: using the ! operator:
// These two lines of code will create the same output
Console.WriteLine(pangram.Contains("fox") == false); // false
Console.WriteLine(!pangram.Contains("fox")); // false