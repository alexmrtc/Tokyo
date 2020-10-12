﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{
    public List<Card> deck = new List<Card>();
    
    public int x;
    public int deckSize;

    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        deckSize = 10;

        for (int i = 0; i < deckSize; i++)
        {
            x = Random.Range(0, 5);
            deck[i] = CardsDatabase.cardList[x];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
