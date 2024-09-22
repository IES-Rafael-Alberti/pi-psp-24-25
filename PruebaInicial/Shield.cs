namespace PruebaInicial;

public class Shield: Protection
{
    public const int DefaultArmor = 10;
    public Shield(int armor = DefaultArmor) : base(armor)
    {
        Name = "Shield";
    }

}