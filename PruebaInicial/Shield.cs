namespace PruebaInicial;

public class Shield: Protection
{
    public new const int DefaultArmor = 10;
    public Shield(int armor = DefaultArmor) : base(armor)
    {
        Name = "Shield";
    }

}