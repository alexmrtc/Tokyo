using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardFunctions
{
    public static Dictionary<string, System.Action> cardFunctions = new Dictionary<string, System.Action>();


    public static Dictionary<string, System.Action<Card>> cardRelatedFunctions = new Dictionary<string, System.Action<Card>>();
    public static Dictionary<string, System.Action> diceRelatedFunctions = new Dictionary<string, System.Action>();

    public static Monster currentMonster;

    public static void Init()
    {
        cardFunctions.Add("Tanques", Tanks);
        cardFunctions.Add("Tren de cercanías", Commuter_train);
        cardFunctions.Add("Cazas de combate", Jet_fighters);
        cardFunctions.Add("Tienda de la esquina", Corner_store);
        cardFunctions.Add("Gran Tormenta", Vast_storm);
        cardFunctions.Add("Órdenes de evacuación", Evacuation_orders);
    }
    
    private static void Tanks()
    {
        currentMonster = GameManager.FindObjectOfType<GameManager>().GetCurrentMonster().GetComponent<Monster>();

        currentMonster.health -= 3;
        currentMonster.victoryPoints += 4;
    }

    private static void Commuter_train()
    {
        currentMonster = GameManager.FindObjectOfType<GameManager>().GetCurrentMonster().GetComponent<Monster>();

        currentMonster.victoryPoints += 2;
    }

    private static void Jet_fighters()
    {
        currentMonster = GameManager.FindObjectOfType<GameManager>().GetCurrentMonster().GetComponent<Monster>();

        currentMonster.health -= 4;
        currentMonster.victoryPoints += 5;
    }

    private static void Corner_store()
    {
        currentMonster = GameManager.FindObjectOfType<GameManager>().GetCurrentMonster().GetComponent<Monster>();

        currentMonster.victoryPoints += 1;
    }

    private static void Vast_storm()
    {
        List<GameObject> monsters = GameManager.FindObjectOfType<GameManager>().GetOtherMonsters();

        foreach (GameObject monster in monsters)
        {
            monster.GetComponent<Monster>().energy -= monster.GetComponent<Monster>().energy / 2;
        }

        currentMonster = GameManager.FindObjectOfType<GameManager>().GetCurrentMonster().GetComponent<Monster>();

        currentMonster.victoryPoints += 2;
    }

    private static void Evacuation_orders()
    {
        List<GameObject> monsters = GameManager.FindObjectOfType<GameManager>().GetOtherMonsters();

        foreach (GameObject monster in monsters)
        {
            monster.GetComponent<Monster>().victoryPoints -= 5;
        }
    }
}
