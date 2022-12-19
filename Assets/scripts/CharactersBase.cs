using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Characters", menuName = "Character/Create new character")]
public class CharactersBase : ScriptableObject
{
    [SerializeField] string name;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] Sprite frontSprite;

    [SerializeField] CharacterType type1;
    [SerializeField] CharacterType type2;

    //Base Stats
    [SerializeField] int maxHP;
    [SerializeField] int attack;
    [SerializeField] int defense;
    [SerializeField] int speed;

    public string Name
    {
        get { return name; }
    }
    public string Description
    {
        get { return description;  }
    }
    public Sprite FrontSprite
    {
        get { return frontSprite; }
    }
    public CharacterType Type1
    {
        get { return type1; }
    }
    public CharacterType Type2
    {
        get { return type2; }
    }
    public int MaxHP
    {
        get { return maxHP; }
    }
    public int Attack
    {
        get { return attack; }
    }
    public int Defense
    {
        get { return defense; }
    }
    public int Speed
    {
        get { return speed; }
    }
}

public enum CharacterType
{
    Normal,
    Ground,
    Flying,
    Healer,
    Wizard,
    Ranger,
    Assassin,
    Tank,
}
