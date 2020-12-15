using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour
{
    public Dice[] dices;

    public int numberOfRolls;
    int startingNumberOfRolls = 3;

    MonsterFunctions monsterTurn;

    MonsterFunctions startingMonster;
    int numAttacks;
    int maxAttackDrawn = 0;

    IEnumerator ThrowAndAssociateDice(List<GameObject> monstersPlaying)
    {
        for (int i = 0; i < monstersPlaying.Count; i++)
        {
            RollDices(monstersPlaying[i].GetComponent<MonsterFunctions>().GetMonster().GetNumDice());
            ResetNumberOfRolls();

            yield return new WaitForSeconds(5);

            monstersPlaying[i].GetComponent<MonsterFunctions>().GetMonster().SetDice(dices);
        }

        StartCoroutine(SetStartingMonster(monstersPlaying));
    }

    IEnumerator SetStartingMonster(List<GameObject> monstersPlaying)
    {
        foreach (GameObject monster in monstersPlaying)
        {
            numAttacks = 0;
            for (int i = 0; i < monster.GetComponent<MonsterFunctions>().GetMonster().GetNumDice(); i++)
            {
                if (monster.GetComponent<MonsterFunctions>().GetMonster().GetDice()[i].CheckSideValue() == 5)
                {
                    numAttacks++;
                }

                Debug.Log("Rolled: " + monster.GetComponent<MonsterFunctions>().GetMonster().GetDice()[i].diceValue);
            }

            if (maxAttackDrawn < numAttacks)
            {
                maxAttackDrawn = numAttacks;
                startingMonster = monster.GetComponent<MonsterFunctions>();
            }
        }

        //for (int i = 0; i < monstersPlaying.Count; i++)
        //{
        //    for (int j = 0; j < monstersPlaying[j].GetComponent<MonsterFunctions>().GetMonster().GetNumDice(); j++)
        //    {
        //        if (monstersPlaying[j].GetComponent<MonsterFunctions>().GetMonster().GetDice()[j].CheckSideValue() == 5)
        //        {
        //            numAttacks++;
        //        }

        //        Debug.Log("Rolled: " + monstersPlaying[i].GetComponent<MonsterFunctions>().GetMonster().GetDice()[i].diceValue);
        //    }

        //    if (maxAttackDrawn < numAttacks)
        //    {
        //        maxAttackDrawn = numAttacks;
        //        startingMonster = monstersPlaying[i].GetComponent<MonsterFunctions>();
        //    }
        //}

        Debug.Log("Starting Monster: " + startingMonster.GetName());
        StartTurn(startingMonster);
        yield return new WaitForSeconds(1);
    }

    // Start is called before the first frame update
    void Start()
    {
        numberOfRolls = startingNumberOfRolls;

        StartGame(GameManager.monsters);
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

    public void InitTurn(List<GameObject> monstersPlaying)
    {
        StartGame(monstersPlaying);
    }

    public void StartGame(List<GameObject> monstersPlaying)
    {
        startingMonster = new MonsterFunctions();

        //foreach (Dice dice in dices)
        //{
        //    dice.RollDice();
        //}

        foreach (GameObject monster in monstersPlaying)
        {
            Debug.Log("Monster playing: " + monster.GetComponent<MonsterFunctions>().GetMonster().GetName());
        }

        StartCoroutine(ThrowAndAssociateDice(monstersPlaying));
        //StartCoroutine(SetStartingMonster(monstersPlaying));

        //foreach (GameObject monster in monstersPlaying)
        //{
        //    monster.GetComponent<MonsterFunctions>().GetMonster().SetDice(dices);
        //    for (int i = 0; i < monster.GetComponent<MonsterFunctions>().GetMonster().GetNumDice(); i++)
        //    {

        //        monster.GetComponent<MonsterFunctions>().GetMonster().GetDice()[i].RollDice();

        //        //No pilla el valor del Dado?

        //        //while (!monster.GetComponent<MonsterFunctions>().GetMonster().GetDice()[i].hasLanded)
        //        //{
        //            if (monster.GetComponent<MonsterFunctions>().GetMonster().GetDice()[i].CheckSideValue() == 5)
        //            {
        //                numAttacks++;
        //            }
        //        //}

        //        Debug.Log("Rolled: " + monster.GetComponent<MonsterFunctions>().GetMonster().GetDice()[i].diceValue);
        //    }

        //    if (maxAttackDrawn < numAttacks)
        //    {
        //        maxAttackDrawn = numAttacks;
        //        startingMonster = monster.GetComponent<MonsterFunctions>();
        //    }
        //}
        //Debug.Log("Starting Monster: " + startingMonster.GetName());
        //StartTurn(startingMonster);
    }

    void StartTurn(MonsterFunctions monster)
    {
        monsterTurn = monster;

        monsterTurn.SetIsTurn(true);
        monsterTurn.SetDice(dices);

        RollDices(monsterTurn.GetNumDice());
    }

    void EndTurn(MonsterFunctions monster)
    {
        monsterTurn.SetIsTurn(false);
    }


    void RollDices(int numDices)
    {
        for (int i = 0; i < numDices; i++)
        {
            if (dices[i].reroll)
            {
                dices[i].RollDice();
            }
        }
    }

    void CheckIfRollsAvailable()
    {
        if (numberOfRolls > 0)
        {
            numberOfRolls--;

            RollDices(monsterTurn.GetNumDice());
        }
    }

    void ResetNumberOfRolls()
    {
        numberOfRolls = startingNumberOfRolls;
    }
}
