using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public int id;
    public string name;
    public int health;
    public int victoryPoints;

    public bool inTokyo;
    public bool dead;

    public Sprite monsterImage;

    public Dice[] dices;

    public int damageTaken;
    public int damageDealt;

    public Monster()
    {

    }

    public Monster(int _id, string _name, int _health, int _victoryPoints, bool _inTokyo, bool _dead, Sprite _monsterImage/*, int _damageTaken, int _damageDealt*/)
    {
        id = _id;
        name = _name;
        health = _health;
        victoryPoints = _victoryPoints;

        inTokyo = _inTokyo;
        dead = _dead;

        monsterImage = _monsterImage;

        //damageTaken = _damageTaken;
        //damageDealt = _damageDealt;
    }

    public void GoToTokyo()
    {
        victoryPoints++;
        inTokyo = true;
    }

    public void CheckIfStillInTokyo()
    {
        if(inTokyo == true)
        {
            victoryPoints += 2;
        }
    }

    public void TakeDamage()
    {
        foreach (Dice dice in dices)
        {
            if(dice.CheckSideValue() == 5)
            {
                damageTaken++;
            }
        }

        health -= damageTaken;
    }

    public void Attack()
    {
        foreach (Dice dice in dices)
        {
            if (dice.CheckSideValue() == 5)
            {
                damageDealt++;
            }
        }
    }

    public void ResetDamage()
    {
        damageDealt = 0;
        damageTaken = 0;
    }
}
