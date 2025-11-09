Console.WriteLine("Hello World");

IEnumerable<string> li = new List<string>()
{
    "Alpha_4"
};

var input = Console.ReadLine();

if (li.Any(name => name.Equals(input)))
    Console.WriteLine("Found it");
else Console.WriteLine("Not found");
