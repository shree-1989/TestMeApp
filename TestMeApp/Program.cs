Console.WriteLine("Hello World");

IEnumerable<string> li = new List<string>()
{
    "Alpha",
    "Beta",
    "Gamma",
    "Delta",
    "Echo",
    "FoxTrot"
};

var input = Console.ReadLine();

if (li.Any(name => name.Equals(input)))
    Console.WriteLine("Found it");
else Console.WriteLine("Not found");
