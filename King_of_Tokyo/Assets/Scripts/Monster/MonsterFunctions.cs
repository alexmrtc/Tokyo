using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterFunctions : Monster
{
    Monster monster;

    public void InitMonster()
    {
        monster = GetComponentInParent<Monster>();
        monster.SetNumDice(6);
    }

    public void GoToTokyo()
    {
        monster.SetVictoryPoints(monster.GetVictoryPoints() + 1);
        monster.SetInTokyo(true);
    }

    public void CheckIfStillInTokyo()
    {
        if (monster.GetInTokyo() == true)
        {
            monster.victoryPoints += 2;
        }
    }

    public void CheckIfCanBuy()
    {
        monster.SetEnergyCostCard(monster.GetCardSelected().cost);
        if ((monster.GetEnergy() - monster.GetEnergyCostCard()) >= 0)
        {
            //int energy = monster.GetEnergy();
            //int energyLoss = (energy -= monster.GetEnergyCostCard());
            monster.SetEnergy(monster.GetEnergy() - monster.GetEnergyCostCard());
            BuyCard();
        }
    }

    public void BuyCard()
    {
        FindDeckGameobject();
        monster.GetCardsOwned().Add(monster.GetCardSelected());
        monster.GetCards().Add(monster.GetCardGameObject());

        PlayerDeck.cardsInDeck.Remove(monster.GetCardSelected());
        monster.GetCardSelected().owned = true;
        monster.GetCardSelected().owner = monster;

        monster.GetCards()[monster.GetNumCardsOwned()].GetComponent<ThisCard>().GoToHand();

        monster.SetNumCardsOwned(monster.GetNumCardsOwned() + 1);

        StartCoroutine(monster.GetDeck().AddCard());
    }


    void FindDeckGameobject()
    {
        monster.SetDeckGameObject(GameObject.FindGameObjectWithTag("Deck"));

        monster.SetDeck(monster.GetDeckGameObject().GetComponent<PlayerDeck>());

        monster.SetHand(monster.GetDeck().hand);
    }

    public Monster GetMonster() { return monster; }
}
