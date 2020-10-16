using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ThisCard : MonoBehaviour
{
    public List<Card> thisCard = new List<Card>();
    public int thisId;

    public int id;
    public string cardName;
    public int cost;
    public bool keep;
    public string description;

    public Text nameText;
    public Text costText;
    public Text keepText;
    public Text descriptionText;

    public Sprite thisSprite;
    public Image thatImage;

    // Start is called before the first frame update
    void Start()
    {
        thisCard[0] = CardsDatabase.cardList[thisId];

        //thisCard[0] = PlayerDeck.cardsInDeck[thisId];
    }

    // Update is called once per frame
    void Update()
    {
        id = thisCard[0].id;
        cardName = thisCard[0].name;
        cost = thisCard[0].cost;
        keep = thisCard[0].keep;
        description = thisCard[0].description;

        thisSprite = thisCard[0].cardImage;

        nameText.text = "" + cardName;
        costText.text = "" + cost;
        if (keep == true)
        {
            keepText.text = "Keep";
        } else
        {
            keepText.text = "Discard";
        }
        descriptionText.text = "" + description;

        thatImage.sprite = thisSprite;
    }
}
