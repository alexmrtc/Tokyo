using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card
{
    public int id;
    public string name;
    public int cost;
    public bool keep;
    public string description;

    public Card()
    {

    }

    public Card(int _id, string _name, int _cost, bool _keep, string _description)
    {
        id = _id;
        name = _name;
        cost = _cost;
        keep = _keep;
        description = _description;
    }
}
