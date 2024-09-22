namespace PruebaInicial;

public class Character
{
    public const int DefaulMaxHP = 10;
    public string Name { get; set; }
    public int MaxHitPoints { get; set; }

    public Character(string name, int maxHitPoints = DefaulMaxHP)
    {
        Name = name;
        MaxHitPoints = maxHitPoints;
    }

    public override string ToString()
    {
        return $"Character: {Name} | Max HitPoints: {MaxHitPoints}";
    }
}