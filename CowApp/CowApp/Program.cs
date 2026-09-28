namespace CowApp;

class Program
{
    static void Main(string[] args)
    {
        List<Cow> cows = new List<Cow>()
        {
            new Cow("Milka", "lila", 4),
            new Cow("Paula", "weiss", 6),
            new Cow("Conny", "schwarz", 4),
            new Cow("Berta", "weiss", 7),
            new Cow("Mathias", "rosa", 4),
            new Cow("Milka", "rosa", 4),
            new Cow("Milka", "lila", 5),
        };
        Console.WriteLine();
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