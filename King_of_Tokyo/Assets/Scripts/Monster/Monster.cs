using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    //Monster Related
    public int id;
    public string name;
    public int health;
    public int victoryPoints;
    public int energy;

    public bool inTokyo;
    public bool dead;
    public bool isTurn;

    public Sprite monsterImage;
    public Sprite monsterPortraitImage;

    public MonsterFunctions monsterFunctions;

    //Dice Related
    public Dice[] dices;

    public int damageTaken;
    public int damageDealt;

    //Card Related
    public List<Card> cardsOwned = new List<Card>();
    public List<GameObject> cards = new List<GameObject>();
    public int numCardsOwned;

    public Card cardSelected;
    public GameObject cardGameObject;
    public int energyCostCard;

    public GameObject hand;

    private PlayerDeck deck;
    private GameObject deckGameObject;

    public Monster()
    {

    }


    public Monster(int _id, string _name, int _health, int _victoryPoints, int _energy, bool _inTokyo, bool _dead, Sprite _monsterImage, Sprite _monsterPortraitImage/*, int _damageTaken, int _damageDealt*/)
    {
        id = _id;
        name = _name;
        health = _health;
        victoryPoints = _victoryPoints;
        energy = _energy;

        inTokyo = _inTokyo;
        dead = _dead;

        monsterImage = _monsterImage;
        monsterPortraitImage = _monsterPortraitImage;

        isTurn = true;
        //damageTaken = _damageTaken;
        //damageDealt = _damageDealt;
        numCardsOwned = 0;
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

    //public void CheckIfCanBuy()
    //{
    //    energyCostCard = cardSelected.cost;
    //    if ((energy - energyCostCard) >= 0)
    //    {
    //        energy -= energyCostCard;
    //        BuyCard();
    //    }
    //}

    //public void BuyCard()
    //{
    //    FindDeckGameobject();
    //    cardsOwned.Add(cardSelected);
    //    cards.Add(cardGameObject);

    //    PlayerDeck.cardsInDeck.Remove(cardSelected);
    //    cardSelected.owned = true;
    //    cardSelected.owner = this;
    //    //energyCostCard = 0;

    //    //cards[numCardsOwned].transform.position = hand.transform.position;
    //    cards[numCardsOwned].GetComponent<ThisCard>().GoToHand();

    //    numCardsOwned++;

    //    StartCoroutine(deck.AddCard());
    //}

    //void FindDeckGameobject()
    //{
    //    deckGameObject = GameObject.FindGameObjectWithTag("Deck");

    //    deck = deckGameObject.GetComponent<PlayerDeck>();
    //}

    #region Getters and Setters
    //Monster Related
    public int GetId() { return id; }
    public void SetId(int idV) { id = idV; }

    public string GetName() { return name; }
    public void SetName(string nameV) { name = nameV; }

    public int GetHealth() { return health; }
    public void SetHealth(int healthV) { health = healthV; }

    public int GetVictoryPoints() { return victoryPoints; }
    public void SetVictoryPoints(int victoryPointsV) { victoryPoints = victoryPointsV; }

    public int GetEnergy()    { return energy;  }
    public void SetEnergy(int energyV) { energy = energyV; }

    public bool GetInTokyo() { return inTokyo; }
    public void SetInTokyo(bool inTokyoV) { inTokyo = inTokyoV; }

    public bool GetDead() { return dead; }
    public void SetDead(bool deadV) { dead = deadV; }

    public bool GetIsTurn() { return isTurn; }
    public void SetIsTurn(bool isTurnV) { isTurn = isTurnV; }

    public Sprite GetMonsterImage() { return monsterImage; }
    public void SetMonsterImage(Sprite monsterImageV) { monsterImage = monsterImageV; }

    public Sprite GetMonsterPortraitImage() { return monsterPortraitImage; }
    public void SetMonsterPortraitImage(Sprite monsterPortraitImageV) { monsterPortraitImage = monsterPortraitImageV; }

    public MonsterFunctions GetMonsterFunctions() { return monsterFunctions; }
    public void SetMonsterFunctions(MonsterFunctions monsterFunctionsV) { monsterFunctions = monsterFunctionsV; }

    //Dice Related
    public Dice[] GetDice() { return dices; }
    public void SetDice(Dice[] diceV) { dices = diceV; }

    public int GetDamageDealt() { return damageDealt; }
    public void SetDamageDealt(int damageDealtV) { damageDealt = damageDealtV; }

    public int GetDamageTaken() { return damageTaken; }
    public void SetDamageTaken(int damageTakenV) { damageTaken = damageTakenV; }

    //Card Related
    public List<Card> GetCardsOwned() { return cardsOwned; }
    public void SetCardsOwned(List<Card> cardsOwnedV) { cardsOwned = cardsOwnedV; }

    public List<GameObject> GetCards() { return cards; }
    public void SetCards(List<GameObject> cardsV) { cards = cardsV; }

    public int GetNumCardsOwned() { return numCardsOwned; }
    public void SetNumCardsOwned(int numCardsOwnedV) { numCardsOwned = numCardsOwnedV; }

    public Card GetCardSelected() { return cardSelected; }
    public void SetCardSelected(Card cardSelectedV) { cardSelected = cardSelectedV; }

    public GameObject GetCardGameObject() { return cardGameObject; }
    public void SetCardGameObject(GameObject cardGameObjectV) { cardGameObject = cardGameObjectV; }

    public int GetEnergyCostCard() { return energyCostCard; }
    public void SetEnergyCostCard(int energyCostCardV) { energyCostCard = energyCostCardV; }

    public GameObject GetHand() { return hand; }
    public void SetHand(GameObject handV) { hand = handV; }

    public PlayerDeck GetDeck()    { return deck; }
    public void SetDeck(PlayerDeck deckV)    { deck = deckV; }

    public GameObject GetDeckGameObject()    { return deckGameObject;  }
    public void SetDeckGameObject(GameObject deckGameObjectV)    { deckGameObject = deckGameObjectV; }
    #endregion
}
