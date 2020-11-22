using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public List<Monster> monstersPlaying = new List<Monster>();

    public List<int> idsMonstersPlaying = new List<int>();

    public GameObject prefabMonster;

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
        foreach (Monster monster in monstersPlaying)
        {
            GameObject m = Instantiate(prefabMonster);

            m.GetComponent<Monster>().id = monster.id;
            m.GetComponent<Monster>().name = monster.name;
            m.GetComponent<Monster>().monsterImage = monster.monsterImage;
            m.GetComponent<Monster>().health = monster.health;
            m.GetComponent<Monster>().victoryPoints = monster.victoryPoints;
            m.name = monster.name;

            SceneManager.MoveGameObjectToScene(m, SceneManager.GetSceneByName("CardTest"));
        }

        foreach (int idMonst in idsMonstersPlaying)
        {
            Debug.Log("Id: " + idMonst);
        }
        // Unload the previous Scene
        SceneManager.UnloadSceneAsync(currentScene);
    }

    //public void AddSelectedMonsterToPlayingMonsters(Monster monster)
    //{
    //    monstersPlaying.Add(monster);
    //}

    //public void RemoveSelectedMonsterFromPlayingMonsters(Monster monster)
    //{
    //    monstersPlaying.Remove(monster);
    //}

    public void AddSelectedMonsterToPlayingMonsters(Monster monster)
    {
        monstersPlaying.Add(monster);

        idsMonstersPlaying.Add(monster.id);

        foreach(Monster monsterP in monstersPlaying)
        {
            Debug.Log("Monster: " + monsterP.name);
        }
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
}
