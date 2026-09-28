namespace CowApp;

public class Cow : IEquatable<Cow> , IComparable<Cow>
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public int Age { get; set; }

    public int KuhlLevel
    {
        get
        {
            return Age + Colour.Length;
            
        }
        private set;
    }

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
    

    public int CompareTo(Cow? other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (other is null) return 1;
        var nameComparison = string.Compare(Name, other.Name, StringComparison.Ordinal);
        if (nameComparison != 0) return nameComparison;
        var colourComparison = string.Compare(Colour, other.Colour, StringComparison.Ordinal);
        if (colourComparison != 0) return colourComparison;
        return Name.CompareTo(other.Name);
    }
}