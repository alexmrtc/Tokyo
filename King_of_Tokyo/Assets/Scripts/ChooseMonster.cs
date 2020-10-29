using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseMonster : MonoBehaviour
{
    public bool monsterActive;

    Monster selectedMonster;

    List<Monster> monsters = new List<Monster>();


    public Text monsterNamePlayers;
    public Image monsterImagePlayers;

    public GameObject activateButton;
    public GameObject deactivateButton;

    public GameObject nextButton;
    public GameObject previousButton;

    public int numMonster;

    //public List<int> idsMonstersPlaying = new List<int>();

    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        monsters = MonsterDatabase.monsterList;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //for (int i = 0; i < gameManager.monstersPlaying.Count; i++)
        //{
        //    idsMonstersPlaying.Add(gameManager.monstersPlaying[i].id);
        //}
    }

    void GenerateRandomNumberNotExisting()
    {
        do
        {
            numMonster = Random.Range(0, 6);
        } while (gameManager.idsMonstersPlaying.Contains(numMonster));
    }

    void AddSelectedMonsterToPlayingMonsters(Monster monster)
    {
        gameManager.monstersPlaying.Add(monster);

        gameManager.idsMonstersPlaying.Add(monster.id);
    }

    void RemoveSelectedMonsterFromPlayingMonsters(Monster monster)
    {
        gameManager.monstersPlaying.Remove(monster);

        for (int i = 0; i < gameManager.idsMonstersPlaying.Count; i++)
        {
            if (gameManager.idsMonstersPlaying[i] == monster.id)
            {
                gameManager.idsMonstersPlaying.Remove(gameManager.idsMonstersPlaying[i]);
            }
        }
    }

    public void ActivateMonster()
    {
        GenerateRandomNumberNotExisting();

        activateButton.SetActive(false);
        deactivateButton.SetActive(true);

        selectedMonster = monsters[numMonster];

        AddSelectedMonsterToPlayingMonsters(selectedMonster);

        monsterImagePlayers.sprite = selectedMonster.monsterPortraitImage;
        monsterNamePlayers.text = selectedMonster.name;

        monsterActive = true;

        nextButton.SetActive(true);
        previousButton.SetActive(true);
    }

    public void DeactivateMonster()
    {
        RemoveSelectedMonsterFromPlayingMonsters(selectedMonster);

        activateButton.SetActive(true);
        deactivateButton.SetActive(false);

        nextButton.SetActive(false);
        previousButton.SetActive(false);

        //selectedMonster = monsters[Random.Range(0, 5)];

        //monsterImagePlayers.sprite = selectedMonster.monsterPortraitImage;
        monsterNamePlayers.text = "";


        monsterActive = false;
    }

    public void NextMonster()
    {
        numMonster++;

        if (numMonster > 5)
        {
            numMonster = 0;
        }


        if (gameManager.idsMonstersPlaying.Contains(numMonster) == false)
        {
            RemoveSelectedMonsterFromPlayingMonsters(selectedMonster);

            //gameManager.idsMonstersPlaying[1] = numMonster;

            selectedMonster = monsters[numMonster];
            monsterImagePlayers.sprite = selectedMonster.monsterPortraitImage;
            monsterNamePlayers.text = selectedMonster.name;

            AddSelectedMonsterToPlayingMonsters(selectedMonster);
        } else
        {
            if (gameManager.idsMonstersPlaying.Count > 6)
            {
                NextMonster();
            }
        }
    }

    public void PreviousMonster()
    {
        numMonster--;

        if (numMonster < 0)
        {
            numMonster = 5;
        }

        if (gameManager.idsMonstersPlaying.Contains(numMonster) == false)
        {
            RemoveSelectedMonsterFromPlayingMonsters(selectedMonster);


            selectedMonster = monsters[numMonster];
            monsterImagePlayers.sprite = selectedMonster.monsterPortraitImage;
            monsterNamePlayers.text = selectedMonster.name;

            AddSelectedMonsterToPlayingMonsters(selectedMonster);
        }
        else
        {
            if(gameManager.idsMonstersPlaying.Count > 6)
            {
                PreviousMonster();
            }
        }
    }
}
