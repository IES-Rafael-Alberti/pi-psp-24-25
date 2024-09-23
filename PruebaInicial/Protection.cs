namespace PruebaInicial;

public abstract class Protection: IItem
{
    public const int DefaultArmor = 5;
    
    public string Name { get; set; }
    public int Armor { get; set; }

    public Protection(int armor = DefaultArmor)
    {
        Armor = armor;
    }

    public virtual void Apply(Character character)
    {
        character.Armor += Armor;
    }

    public override string ToString()
    {
        return $"Protection Name: {Name}, Armor: {Armor}";
    }
}