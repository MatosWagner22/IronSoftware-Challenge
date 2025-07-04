// See https://aka.ms/new-console-template for more information

using PhoneKeypadLib;

Console.WriteLine("Old Phone Keypad Simulator");
Console.WriteLine("Enter key sequence (end with '#'):");

string input = Console.ReadLine();
string output = PhoneKeypad.Convert(input);

Console.WriteLine($"Output: {output}");
Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();
