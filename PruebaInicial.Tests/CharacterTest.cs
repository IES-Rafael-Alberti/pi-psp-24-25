using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using PruebaInicial;
using Xunit;

namespace PruebaInicial.Tests;

[TestSubject(typeof(Character))]
public class CharacterTest: IDisposable
{
    const string testName = "TestName";
    private Character character;
    const int maxHP = 10;
    const int testHP = Character.DefaulMaxHP;
    private List<Character> characters = new List<Character>();
    
    public CharacterTest()
    {
        character = new Character(testName);
        characters.Add(character);
    }

    public void Dispose()
    {
        characters.Clear();
    }

    [Fact]
    public void NameTest()
    {
        Assert.Equal(testName, character.Name);
    }
    
    [Fact]
    public void HPTest()
    {
        Assert.Equal(maxHP, character.MaxHitPoints);
        character = new Character(testName, testHP);
        Assert.Equal(testHP, character.MaxHitPoints);
    }

}