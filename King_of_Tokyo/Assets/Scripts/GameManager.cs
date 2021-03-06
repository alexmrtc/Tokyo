﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public List<Monster> monstersPlaying = new List<Monster>();

    public List<int> idsMonstersPlaying = new List<int>();

    public GameObject prefabMonster;

    public static List<GameObject> monsters = new List<GameObject>();

    public Turn turn;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GoToTest()
    {

        StartCoroutine("LoadCardScene");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    IEnumerator LoadCardScene()
    {
        // Set the current Scene to be able to unload it later
        Scene currentScene = SceneManager.GetActiveScene();

        // The Application loads the Scene in the background at the same time as the current Scene.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("CardTest", LoadSceneMode.Additive);

        // Wait until the last operation fully loads to return anything
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        // Move the GameObject (you attach this in the Inspector) to the newly loaded Scene
        turn = GameObject.Find("DiceHolder").GetComponent<Turn>();

        foreach (Monster monster in monstersPlaying)
        {
            GameObject m = Instantiate(prefabMonster);

            m.GetComponent<Monster>().id = monster.id;
            m.GetComponent<Monster>().name = monster.name;
            m.GetComponent<Monster>().monsterImage = monster.monsterImage;
            m.GetComponent<Monster>().health = monster.health;
            m.GetComponent<Monster>().victoryPoints = monster.victoryPoints;

            //Init MonsterFunctions
            m.GetComponent<Monster>().monsterFunctions.InitMonster();
            m.name = monster.name;

            monsters.Add(m);

            SceneManager.MoveGameObjectToScene(m, SceneManager.GetSceneByName("CardTest"));
        }

        turn.StartGame(monsters);

        foreach (int idMonst in idsMonstersPlaying)
        {
            Debug.Log("Id: " + idMonst);
        }
        // Unload the previous Scene
        SceneManager.UnloadSceneAsync(currentScene);
    }

    public void AddSelectedMonsterToPlayingMonsters(Monster monster)
    {
        monstersPlaying.Add(monster);

        idsMonstersPlaying.Add(monster.id);
    }

    public void RemoveSelectedMonsterFromPlayingMonsters(Monster monster)
    {
        monstersPlaying.Remove(monster);

        for (int i = 0; i < idsMonstersPlaying.Count; i++)
        {
            if (idsMonstersPlaying[i] == monster.id)
            {
                idsMonstersPlaying.Remove(idsMonstersPlaying[i]);
            }
        }
    }

    public void CheckMonsterCanAfford()
    {
        foreach (GameObject monster in monsters)
        {
            if (monster.GetComponent<Monster>().isTurn == true)
            {
                monster.GetComponent<Monster>().monsterFunctions.CheckIfCanBuy();
            }
        }
    }


    #region GetMonsters
    public GameObject GetCurrentMonster()
    {
        GameObject currentMonster = null;

        foreach(GameObject monster in monsters)
        {
            if (monster.GetComponent<Monster>().isTurn == true)
            {
                currentMonster = monster;
            }
        }

        return currentMonster;
    }

    public List<GameObject> GetOtherMonsters()
    {
        List<GameObject> otherMonsters = new List<GameObject>();

        foreach (GameObject monster in monsters)
        {
            if (monster.GetComponent<Monster>().isTurn != true)
            {
                otherMonsters.Add(monster);
            }
        }

        return otherMonsters;
    }

    #endregion
}
