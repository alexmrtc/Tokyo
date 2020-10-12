using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card> ();

    private void Awake()
    {
        cardList.Add(new Card(0, "Tanks", 4, false, "Gain 4 Stars and take 3 damage", Resources.Load<Sprite>("Tanks")));
        cardList.Add(new Card(1, "Extra Head", 7, true, "You get 1 extra die", Resources.Load<Sprite>("Extra_head")));
        cardList.Add(new Card(2, "Intimidating Roar", 3, true, "Monsters in Tokyo must yield if you damage them", Resources.Load<Sprite>("Intimidating_roar")));
        cardList.Add(new Card(3, "Cannibalistic", 5, true, "When you deal damage, gain 1 Heart", Resources.Load<Sprite>("Cannibalistic")));
        cardList.Add(new Card(4, "Regeneration", 4, true, "When you heal, heal 1 extra damage", Resources.Load<Sprite>("Regeneration")));

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
