using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks.Dataflow;
using static System.Console;

int numberOfApples = 12;
decimal pricePerApple = 0.35M;

Console.WriteLine(
    format: "{0} apples costs {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);
string formatted = string.Format(
    format: "{0} apples costs {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);
// WriteToFile(formatted); // 문자열을 파일에 쓴다.

Console.WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");

// private const string firstname = "Omar";
// private const string lastname = "Rudberg";
// private const string fullname = firstname + " " + lastname;

// private const string fullname = $"{firstname} {lastname}";

string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount = 56789;
Console.WriteLine(
    format: "{0, -10} {1, 6}",
    arg0: "Name",
    arg1: "Count");
Console.WriteLine(
    format: "{0, -10} {1, 6:N0}",
    arg0: applesText,
    arg1: applesCount);
Console.WriteLine(
    format: "{0, -10} {1, 6:N0}",
    arg0: bananasText,
    arg1: bananasCount);


// Console.Write("Type your first name and press ENTER: ");
// string? firstName = Console.ReadLine();
// Console.Write("Type your age and press ENTER: ");
// string? age = Console.ReadLine();
// Console.WriteLine(
//     $"Hello {firstName}, you look good for {age}.");


Write("Press any key combination: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();
WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
    arg0: key.Key,
    arg1: key.KeyChar,
    arg2: key.Modifiers);