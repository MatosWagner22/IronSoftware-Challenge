// See https://aka.ms/new-console-template for more information

using PhoneKeypadLib;

string title = "Phone Keypad Simulator\n";
Console.WriteLine(title.PadLeft(((Console.WindowWidth - title.Length)/2) + title.Length));
Console.Write("\tEnter key sequence (end with '#'): ");

string input = Console.ReadLine();

Console.WriteLine($"\n\tOutput: {PhoneKeypad.Translate(input)}");
Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();
