using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

[System.Serializable]

public class Card
{
    public int id;
    public string name;
    public int cost;
    public bool keep;
    public string description;

    public Sprite cardImage;

    public bool owned;
    public Monster owner;

    protected Action<Monster> cardFunction;

    public Card()
    {

    }

    public Card(int _id, string _name, int _cost, bool _keep, string _description, Sprite _cardImage)
    {
        id = _id;
        name = _name;
        cost = _cost;
        keep = _keep;
        description = _description;

        cardImage = _cardImage;
    }

    public virtual void CardUse()
    {
        cardFunction?.Invoke(owner);
    }
}
