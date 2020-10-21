using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDeck : MonoBehaviour
{
    public List<Card> deck = new List<Card>();
    public List<Card> container = new List<Card>();

    public static List<Card> cardsInDeck = new List<Card>();

    public int x;
    public int deckSize;

    public GameObject store;

    public GameObject cardPrefab;

    public Image cardZoom;

    //private void Awake()
    //{
    //    x = 0;
    //    deckSize = 10;

    //    for (int i = 0; i < deckSize; i++)
    //    {
    //        x = Random.Range(0, 4);
    //        deck[i] = CardsDatabase.cardList[x];
    //    }
    //    cardsInDeck = deck;
    //}

    // Start is called before the first frame update
    void Start()
    {
        cardZoom.enabled = false;

        x = 0;
        deckSize = 10;

        for (int i = 0; i < deckSize; i++)
        {
            x = Random.Range(0, 4);
            deck[i] = CardsDatabase.cardList[x];
        }
        //cardsInDeck.Add(deck[0]);

        StartCoroutine(StartGame());
    }

    // Update is called once per frame
    void Update()
    {
        cardsInDeck = deck;
        //Debug.Log("Cards In Deck Size: " + cardsInDeck.Count);
        //foreach(Card card in cardsInDeck)
        //{
        //    Debug.Log(card.name);
        //}

    }

    public void Shuffle()
    {
        for (int j = 0; j < deckSize; j++)
        {
            container[0] = deck[j];
            int randomIndex = Random.Range(1, deckSize);
            deck[j] = deck[randomIndex];
            deck[randomIndex] = container[0];
        }
    }

    IEnumerator StartGame()
    {
        for(int i = 0; i <=2; i++)
        {
            yield return new WaitForSeconds(1);
            Instantiate(cardPrefab, store.transform.position, store.transform.rotation);
        }
    }

    public IEnumerator AddCard()
    {
        yield return new WaitForSeconds(1);
        Instantiate(cardPrefab, store.transform.position, store.transform.rotation);
    }
}
