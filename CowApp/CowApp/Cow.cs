namespace CowApp;

public class Cow : IEquatable<Cow> , IComparable<Cow>
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public int Age { get; set; }
    
    public Cow(string name, string colour, int age)
    {
        Name = name;
        Colour = colour;
        Age = age;
    }


    public bool Equals(Cow? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return Name == other.Name && Colour == other.Colour && Age == other.Age;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Colour, Age);
    }
}