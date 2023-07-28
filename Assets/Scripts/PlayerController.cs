using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //attach desired character data to the character controller
    [SerializeField] private CharacterData _data;

    //creates an instance of the level up system for the character
    LevelSystem levelSystemInstance;

    //On awake, finds the level system object in the scene and passes the desired character data to the level system
    void Start()
    {
        levelSystemInstance = FindObjectOfType<LevelSystem>();
        levelSystemInstance.Initialize(_data);
    }

    //used to test EXP gain
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            levelSystemInstance.AddEXP(100);
            Debug.Log("EXP Gained!");
        }

        //reset stats
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            _data.Level = 1;
            _data.Health = 10;
            _data.Attack = 3;
            _data.Defense = 3;
            _data.Speed = 3;

            levelSystemInstance.UpdateNeededEXP();

            Debug.Log("Stats Reset!");
        }
    }
}
