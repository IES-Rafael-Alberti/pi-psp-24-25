namespace PruebaInicial;

public class Sword: Weapon
{
    public const int DefaultDamage = 15;

    public Sword(int damage = DefaultDamage): base(damage)
    {
        Name = "Sword";
    }
}