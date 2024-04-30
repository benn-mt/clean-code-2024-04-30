namespace CleanCode;

public class Chance
{
    private readonly double likelihood;

    public Chance(double likelihood)
    {
        this.likelihood = likelihood;
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Chance){
            return false;
        }
        return this.Equals(obj as Chance);
    }

    public bool Equals(Chance other){
        return this.likelihood == other.likelihood;
    }
}