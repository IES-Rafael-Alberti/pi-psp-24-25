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

    private List<IItem> _inventory;

    public Character(string name, int maxHitPoints = DefaultMaxHP, int baseDamage = DefaultBaseDamage, int baseArmor = DefaultBaseArmor)
    {
        Name = name;
        MaxHitPoints = maxHitPoints;
        HitPoints = MaxHitPoints;
        BaseDamage = baseDamage;
        BaseArmor = baseArmor;
        _inventory = new List<IItem>();
    }

    // reduced method declaration
    public void AddItem(IItem item) => _inventory.Add(item);
    public bool RemoveItem(IItem item) => _inventory.Remove(item);
    public int InventoryCount() => _inventory.Count;
    
    // normal method declaration
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
        // initialize stats
        Damage = BaseDamage;
        Armor = BaseArmor;
        // apply item effects
        foreach (var item in _inventory)
        {
            item.Apply(this);
        }
    }

    public void Heal(int amount)
    {
        // controls HP not past MaxHP
        if (amount + HitPoints > MaxHitPoints)
            HitPoints = MaxHitPoints;
        else
            HitPoints += amount;
    }

    public void ReceiveDamage(int amount)
    {
        // controls HP not less than 0
        if (HitPoints - amount < 0)
            HitPoints = 0;
        else
            HitPoints -= amount;
    }
    
    // for manual testing purposes
    public override string ToString()
    {
        string result = $"Character: {Name} | HP: {HitPoints}/{MaxHitPoints}\n";
        result += "  Inventory:\n";
        foreach (var item in _inventory)
        {
            result += $"    {item}\n";
        }
        result += $"  Attack: {Attack()}\n";
        result += $"  Defense: {Defense()}\n";
        return result;
    }
}