namespace CowApp;

public class CompareByAge : IComparer<Cow>
{
    public int Compare(Cow x, Cow y)
    {
        if(ReferenceEquals(x, y)) return 0;
        if (y == null) return 1;
        if (x == null) return -1;
        return x.Age.CompareTo(y.Age);
    }
}