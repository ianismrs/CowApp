namespace CowApp;

class Program
{
    static void Main(string[] args)
    {
        List<Cow> cows = new List<Cow>();
        if (File.Exists("input.txt"))
        {
            using (StreamReader reader = new StreamReader("input.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split(';');
                    if(parts.Length != 3) continue;
                    string name = parts[0];
                    string colour = parts[1];
                    if (int.TryParse(parts[2], out int age) &&
                        !string.IsNullOrWhiteSpace(name) &&
                        !string.IsNullOrWhiteSpace(colour) &&
                        age >= 0)
                    {
                        cows.Add(new Cow(name, colour, age));
                    }
                }
            }
        }

        Console.WriteLine("Every sort is ascending");
        Console.WriteLine("Sort by Names:");
        cows.Sort(new CompareByNames());
        foreach (Cow cow in cows)
        {
            Console.WriteLine($"{cow.Name} {cow.Colour} {cow.Age}");
        }

        Console.WriteLine();
        Console.WriteLine("Sort by Age:");
        cows.Sort(new CompareByAge());
        foreach (Cow cow in cows)
        {
            Console.WriteLine($"{cow.Name} {cow.Colour} {cow.Age}");
        }
        Console.WriteLine();
        Console.WriteLine("Sort by Colour:");
        cows.Sort(new CompareByColour());
        foreach (Cow cow in cows)
        {
            Console.WriteLine($"{cow.Name} {cow.Colour} {cow.Age}");
        }
        Console.WriteLine();
        Console.WriteLine("Sort by Kuhl Level:");
        cows.Sort(new CompareByKuhllevel());
        foreach (Cow cow in cows)
        {
            Console.WriteLine($"{cow.Name} {cow.Colour} {cow.Age} {cow.KuhlLevel}");
        }
    }
}