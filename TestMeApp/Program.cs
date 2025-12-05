using TestMeApp;

Console.WriteLine("Hello World");

IEnumerable<string> li = new List<string>()
{
    "Alpha_16"
};

var input = Console.ReadLine();

new TestClass().getName();

if (li.Any(name => name.Equals(input)))
    Console.WriteLine("Found it");
else Console.WriteLine("Not found");
