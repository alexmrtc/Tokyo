using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardFunctions : MonoBehaviour
{
    public static Dictionary<string, System.Action> cardFunctions = new Dictionary<string, System.Action>();


    public static Dictionary<string, System.Action<Card>> cardRelatedFunctions = new Dictionary<string, System.Action<Card>>();
    public static Dictionary<string, System.Action> diceRelatedFunctions = new Dictionary<string, System.Action>();

    public static Monster currentMonster;
    public static List<GameObject> monsters = new List<GameObject>();

    public static void Init()
    {
        //Descartable Cards
        cardFunctions.Add("Curar", Heal);
        cardFunctions.Add("Rascacielos", Skyscraper);
        cardFunctions.Add("Edificio de apartamentos", Apartment_building);
        cardFunctions.Add("Tanques", Tanks);
        cardFunctions.Add("Tren de cercanías", Commuter_train);
        cardFunctions.Add("Cazas de combate", Jet_fighters);
        cardFunctions.Add("Guardia Nacional", National_guard);
        cardFunctions.Add("Tienda de la esquina", Corner_store);
        cardFunctions.Add("Central nuclear", Nuclear_power_plant);
        cardFunctions.Add("Caído del cielo", Drop_from_high_altitude);
        cardFunctions.Add("Recargar", Energize);
        cardFunctions.Add("Gran Tormenta", Vast_storm);
        cardFunctions.Add("Refinería de gas", Gas_refinery);
        cardFunctions.Add("Órdenes de evacuación", Evacuation_orders);
        cardFunctions.Add("Lanzallamas", Fire_blast);
        cardFunctions.Add("Bombardeo estratégico", High_altitude_bombing);

        //Permanent Cards
    }

    #region Descartable Cards
    private static void Heal()
    {
        currentMonster = GameManager.FindObjectOfType<GameManager>().GetCurrentMonster().GetComponent<Monster>();

        currentMonster.health += 2;
    }

    private static void Skyscraper()
    {
        currentMonster = GameManager.FindObjectOfType<GameManager>().GetCurrentMonster().GetComponent<Monster>();

        currentMonster.victoryPoints += 4;
    }

    private static void Apartment_building()
    {
        currentMonster = GameManager.FindObjectOfType<GameManager>().GetCurrentMonster().GetComponent<Monster>();

        currentMonster.victoryPoints += 3;
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

    private static void National_guard()
    {
        currentMonster = GameManager.FindObjectOfType<GameManager>().GetCurrentMonster().GetComponent<Monster>();

        currentMonster.health -= 2;
        currentMonster.victoryPoints += 2;
    }

    private static void Corner_store()
    {
        currentMonster = GameManager.FindObjectOfType<GameManager>().GetCurrentMonster().GetComponent<Monster>();

        currentMonster.victoryPoints += 1;
    }

    private static void Nuclear_power_plant()
    {
        currentMonster = GameManager.FindObjectOfType<GameManager>().GetCurrentMonster().GetComponent<Monster>();

        currentMonster.victoryPoints += 2;
        currentMonster.health += 3;
    }

    private static void Drop_from_high_altitude()
    {
        currentMonster = GameManager.FindObjectOfType<GameManager>().GetCurrentMonster().GetComponent<Monster>();

        currentMonster.victoryPoints += 2;
        currentMonster.inTokyo = true;

        monsters = GameManager.FindObjectOfType<GameManager>().GetOtherMonsters();

        foreach (GameObject monster in monsters)
        {
            monster.GetComponent<Monster>().inTokyo = false;
        }
    }

    private static void Energize()
    {
        currentMonster = GameManager.FindObjectOfType<GameManager>().GetCurrentMonster().GetComponent<Monster>();

        currentMonster.energy += 9;
    }

    private static void Vast_storm()
    {
        monsters = GameManager.FindObjectOfType<GameManager>().GetOtherMonsters();

        foreach (GameObject monster in monsters)
        {
            monster.GetComponent<Monster>().energy -= monster.GetComponent<Monster>().energy / 2;
        }

        currentMonster = GameManager.FindObjectOfType<GameManager>().GetCurrentMonster().GetComponent<Monster>();

        currentMonster.victoryPoints += 2;
    }

    private static void Gas_refinery()
    {
        monsters = GameManager.FindObjectOfType<GameManager>().GetOtherMonsters();

        foreach (GameObject monster in monsters)
        {
            monster.GetComponent<Monster>().health -= 3;
        }

        currentMonster = GameManager.FindObjectOfType<GameManager>().GetCurrentMonster().GetComponent<Monster>();

        currentMonster.victoryPoints += 2;
    }

    private static void Evacuation_orders()
    {
        monsters = GameManager.FindObjectOfType<GameManager>().GetOtherMonsters();

        foreach (GameObject monster in monsters)
        {
            monster.GetComponent<Monster>().victoryPoints -= 5;
        }
    }

    private static void Fire_blast()
    {
        monsters = GameManager.FindObjectOfType<GameManager>().GetOtherMonsters();

        foreach (GameObject monster in monsters)
        {
            monster.GetComponent<Monster>().health -= 2;
        }
    }

    private static void High_altitude_bombing()
    {
        monsters = GameManager.FindObjectOfType<GameManager>().GetOtherMonsters();

        foreach (GameObject monster in monsters)
        {
            monster.GetComponent<Monster>().health -= 3;
        }

        currentMonster = GameManager.FindObjectOfType<GameManager>().GetCurrentMonster().GetComponent<Monster>();

        currentMonster.health -= 3;
    }
    #endregion

    #region Permanent Cards

    #endregion

    public void Use(){
        Apartment_building();
        High_altitude_bombing();
        Vast_storm();
    }
}
