using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    public int _currentEXP = 0;
    public int _EXPToNextLevel = 100;

    private CharacterData _characterData;

    //Pass data from character controller to level them up
    public void Initialize(CharacterData passedData)
    {
        _characterData = passedData;

        //check if current character level is higher than expected and adjust EXP needed
        UpdateNeededEXP();
    }

    //when function is called, exp is added to current exp
    //checks if level up needs to be called
    //excess exp gained is given to current exp
    public void AddEXP(int EXPGained)
    {
        _currentEXP += EXPGained;

        if (_currentEXP >= _EXPToNextLevel)
        {
            int excessEXP = _currentEXP - _EXPToNextLevel;
            LevelUp();
            _currentEXP = excessEXP;
        }
    }

    //when function is called changes the character data that was passed to the level system
    public void LevelUp()
    {
        Debug.Log("Level Up!");
        _characterData.Level++;
        _characterData.Health += 10;
        _characterData.Attack += 2;
        _characterData.Defense += 2;
        _characterData.Speed += 2;

        UpdateNeededEXP();
    }

    //increases the exp needed to reach the next level
    public int UpdateNeededEXP()
    {
        if (_characterData.Level > 1)
        {
            _EXPToNextLevel = _EXPToNextLevel * (_characterData.Level * 2);
        }
        else
        {
            _EXPToNextLevel = _EXPToNextLevel * 2;
        }

        if(_characterData.Level == 1)
        {
            _EXPToNextLevel = 100;
        }
        return _EXPToNextLevel;
    }
}
