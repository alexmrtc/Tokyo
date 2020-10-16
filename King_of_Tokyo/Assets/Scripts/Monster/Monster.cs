using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public int id;
    public string name;
    public int health;
    public int victoryPoints;
    public int energy;

    public bool inTokyo;
    public bool dead;

    public bool isTurn;

    public Sprite monsterImage;

    public Dice[] dices;

    public int damageTaken;
    public int damageDealt;

    public List<Card> cardsOwned = new List<Card>();

    int energyCostCard;

    public Card cardSelected;

    public Monster()
    {

    }

    public Monster(int _id, string _name, int _health, int _victoryPoints, int _energy, bool _inTokyo, bool _dead, Sprite _monsterImage/*, int _damageTaken, int _damageDealt*/)
    {
        id = _id;
        name = _name;
        health = _health;
        victoryPoints = _victoryPoints;
        energy = _energy;

        inTokyo = _inTokyo;
        dead = _dead;

        monsterImage = _monsterImage;

        isTurn = true;
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

    public void CheckIfCanBuy()
    {
        energyCostCard = PlayerDeck.cardsInDeck[2].cost;
        if ((energy - energyCostCard) >= 0)
        {
            BuyCard();
            energy -= energyCostCard;
        }
    }

    public void BuyCard()
    {
        cardsOwned.Add(cardSelected);

        PlayerDeck.cardsInDeck.Remove(cardSelected);
    }
}
