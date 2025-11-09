Console.WriteLine("Hello World");

IEnumerable<string> li = new List<string>()
{
    "Alpha_12"
};

var input = Console.ReadLine();

if (li.Any(name => name.Equals(input)))
    Console.WriteLine("Found it");
else Console.WriteLine("Not found");
