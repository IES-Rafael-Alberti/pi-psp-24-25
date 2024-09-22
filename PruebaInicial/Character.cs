namespace PruebaInicial;

public class Character
{
    public const int DefaultMaxHP = 10;
    public const int DefaultBaseDamage = 1;
    public const int DefaultBaseArmor = 0;
    public string Name { get; set; }
    public int MaxHitPoints { get; set; }
    public int HitPoints { get; set; }
    public int BaseDamage { get; set; }
    public int Damage { get; set; }
    public int BaseArmor { get; set; }
    public int Armor { get; set; }

    private List<IITem> _inventory;

    public Character(string name, int maxHitPoints = DefaultMaxHP, int baseDamage = DefaultBaseDamage, int baseArmor = DefaultBaseArmor)
    {
        Name = name;
        MaxHitPoints = maxHitPoints;
        HitPoints = MaxHitPoints;
        BaseDamage = baseDamage;
        BaseArmor = baseArmor;
        _inventory = new List<IITem>();
    }

    public void AddItem(IITem item) => _inventory.Add(item);
    public bool RemoveItem(IITem item) => _inventory.Remove(item);
    
    public int InventoryCount() => _inventory.Count;

    public int Attack()
    {
        ApplyInventory();
        return Damage;
    }
    
    public int Defense()
    {
        ApplyInventory();
        return Armor;
    }

    private void ApplyInventory()
    {
        Damage = BaseDamage;
        Armor = BaseArmor;
        foreach (var item in _inventory)
        {
            item.Apply(this);
        }
    }

    void Heal(int amount)
    {
        HitPoints += amount;
    }

    void ReceiveDamage(int amount)
    {
        HitPoints -= amount;
    }

    
    public override string ToString()
    {
        return $"Character: {Name} | Max HitPoints: {MaxHitPoints}";
    }
}