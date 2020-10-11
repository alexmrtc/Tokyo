using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card> ();

    private void Awake()
    {
        cardList.Add(new Card(0, "National Guard", 3, false, "Increase 2 Stars, lose 2 Hearts"));
        cardList.Add(new Card(1, "Herbivore", 5, true, "Gain 1 Star in your turn if you don't damage anyone"));
        cardList.Add(new Card(2, "Intimidating Roar", 3, true, "Monsters in Tokyo must yield if you damage them"));
        cardList.Add(new Card(3, "Cannibalistic", 5, true, "When you deal damage, gain 1 Heart"));
        cardList.Add(new Card(4, "Fire Breathing", 4, true, "Your neighbours take 1 extra damage when you deal damage"));

        for (int i = 0; i < cardList.Count; i++)
        {
            Debug.Log("Card: " + cardList[i].id);
            Debug.Log("Name: " + cardList[i].name);
            Debug.Log("Cost: " + cardList[i].cost);
            Debug.Log("Keep: " + cardList[i].keep.ToString());
            Debug.Log("Description: " + cardList[i].description);
        }
    }

    public void Start()
    {
        //for (int i = 0; i < cardlist.count; i++)
        //{
        //    debug.log("card: " + cardlist[i].id);
        //    debug.log("name: " + cardlist[i].name);
        //    debug.log("cost: " + cardlist[i].cost);
        //    debug.log("keep: " + cardlist[i].keep.tostring());
        //    debug.log("description: " + cardlist[i].description);
        //}
    }

}
