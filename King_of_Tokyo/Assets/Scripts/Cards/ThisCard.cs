using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ThisCard : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
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

    public bool owned;
    public bool selected;

    public Monster[] monsters;

    public int deckSize;

    public GameObject cardZoomed;
    Image imageCardZoom;
    // Start is called before the first frame update
    void Start()
    {
        cardZoomed = GameObject.FindGameObjectWithTag("Image");
        imageCardZoom = cardZoomed.GetComponent<Image>();


        monsters = FindObjectsOfType<Monster>();

        selected = false;

        //deckSize = PlayerDeck.cardsInDeck.Count;

        deckSize = 4;

        thisId = Random.Range(0, deckSize);


        //AssignCard();
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

        owned = thisCard[0].owned;


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


    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("click");
        if (selected == true)
        {
            selected = false;
        }
        else
        {
            selected = true;

            foreach (Monster monster in monsters)
            {
                if (monster.isTurn == true)
                {
                    monster.cardSelected = thisCard[0];
                }
            }
        }
        //throw new System.NotImplementedException();
    }

    private void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("mouse over");
    }

    void AssignCard()
    {
        thisCard.Add(PlayerDeck.cardsInDeck[thisId]);
    }


    public void OnPointerExit(PointerEventData eventData)
    {
        imageCardZoom.enabled = false;

        Debug.Log("mouse bye");


        //throw new System.NotImplementedException();
    }

    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        cardZoomed.GetComponent<Image>().sprite = thisCard[0].cardImage;
        imageCardZoom.enabled = true;
        Debug.Log("mouse over");
        //throw new System.NotImplementedException();
    }
}
