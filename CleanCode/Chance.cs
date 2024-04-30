
namespace CleanCode;

public class Chance
{
    private readonly decimal likelihood;

    public Chance(double likelihood): this((decimal)likelihood){}

    public Chance(decimal likelihood)
    {
        this.likelihood = likelihood;
    }

    public Chance And(Chance other)
    {
        return new Chance(this.likelihood * other.likelihood);
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Chance){
            return false;
        }
        return this.Equals((Chance)obj);
    }

    public bool Equals(Chance other){
        return this.likelihood == other.likelihood;
    }

    public override string ToString()
    {
        return this.likelihood.ToString();
    }
}