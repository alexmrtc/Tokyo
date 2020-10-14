using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour
{
    public Dice[] dices;

    public int numberOfRolls;

    // Start is called before the first frame update
    void Start()
    {
        numberOfRolls = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CheckIfRollsAvailable();
        }

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            numberOfRolls = 3;
        }
    }


    void RollDices()
    {
        foreach (Dice dice in dices)
        {
            if (dice.reroll)
            {
                dice.RollDice();
            }
        }
    }

    void CheckIfRollsAvailable()
    {
        if (numberOfRolls > 0)
        {
            numberOfRolls--;

            RollDices();
        }
    }
}
