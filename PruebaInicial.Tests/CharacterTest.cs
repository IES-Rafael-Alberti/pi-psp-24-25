using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Xunit;

namespace PruebaInicial.Tests;

[TestSubject(typeof(Character))]
public class CharacterTest: IDisposable
{
    private const string TestName = "TestName";
    private const int MaxHp = Character.DefaultMaxHP;
    private const int TestHp = 15;

    private Character _character;
    private readonly List<Character> _characters = new List<Character>();
    
    public CharacterTest()
    {
        _character = new Character(TestName);
        _characters.Add(_character);
        _character.AddItem(new Axe());
        _character.AddItem(new Sword());
        _character.AddItem(new Helmet());
        _character.AddItem(new Shield());
    }

    public void Dispose()
    {
        _characters.Clear();
    }

    [Fact]
    public void CharactersTest()
    {
        Assert.Single(_characters);
    }
    
    [Fact]
    public void NameTest()
    {
        Assert.Equal(TestName, _character.Name);
    }
    
    [Fact]
    public void HpTest()
    {
        Assert.Equal(MaxHp, _character.MaxHitPoints);
        _character = new Character(TestName, TestHp);
        Assert.Equal(TestHp, _character.MaxHitPoints);
    }

    [Fact]
    public void InventoryTest()
    {
        Assert.Equal(4, _character.InventoryCount());
        Assert.Equal(Axe.DefaultDamage + Sword.DefaultDamage + _character.BaseDamage, _character.Attack());
        Assert.Equal(Shield.DefaultArmor + Helmet.DefaultArmor + _character.BaseArmor, _character.Defense());
        var newItem = new Axe();
        _character.AddItem(newItem);
        Assert.Equal(5, _character.InventoryCount());
        Assert.Equal(Axe.DefaultDamage*2 + Sword.DefaultDamage + _character.BaseDamage, _character.Attack());
        _character.RemoveItem(newItem);
        Assert.Equal(4, _character.InventoryCount());
        Assert.Equal(Axe.DefaultDamage + Sword.DefaultDamage + _character.BaseDamage, _character.Attack());
        _character.AddItem(new Shield());
        Assert.Equal(Shield.DefaultArmor*2 + Helmet.DefaultArmor + _character.BaseArmor, _character.Defense());
    }

}