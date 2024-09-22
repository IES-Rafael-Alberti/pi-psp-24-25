namespace PruebaInicial;

public abstract class Weapon: IITem
{
    public const int DefaultDamage = 10; 
    public string Name { get; set; }
    public int Damage { get; set; }

    public Weapon(int damage = DefaultDamage)
    {
        Damage = damage;
    }
    
    public void Apply(Character character)
    {
        character.Damage += Damage;
    }

    public override string ToString()
    {
        return $"Weapon Name: {Name}, Damage: {Damage}";
    }
}