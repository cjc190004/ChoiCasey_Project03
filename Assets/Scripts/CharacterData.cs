using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "PlayerData_", menuName = "UnitData/Player")]
public class CharacterData : ScriptableObject
{
    //shows character stats in Unity inspector

    [Header("Character Stats: ")]

    [SerializeField] private int _health = 10;
    [SerializeField] private int _attack = 3;
    [SerializeField] private int _defense = 3;
    [SerializeField] private int _speed = 3;
    [SerializeField] private int _level = 1;

    //receives stat values for a character and will change the value if level up is called
    public int Health
    {
        get { return _health; }
        set { _health = value; }
    }

    public int Attack
    {
        get { return _attack; }
        set { _attack = value; }
    }

    public int Defense
    {
        get { return _defense; }
        set { _defense = value; }
    }

    public int Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }

    public int Level
    {
        get { return _level; }
        set { _level = value; }
    }

}
