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

    public List<int> idsMonstersPlaying = new List<int>();

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
        //numMonster = Random.Range(0, 5);

        for (int i = 0; i < gameManager.monstersPlaying.Count; i++)
        {
            idsMonstersPlaying.Add(gameManager.monstersPlaying[i].id);
        }

        do
        {
            //if (idsMonstersPlaying.Contains(numMonster))
            //{
            numMonster = Random.Range(0, 6);
            //}
        } while (idsMonstersPlaying.Contains(numMonster) );
    }

    void AddSelectedMonsterToPlayingMonsters(Monster monster)
    {
        gameManager.monstersPlaying.Add(monster);
    }

    void RemoveSelectedMonsterFromPlayingMonsters(Monster monster)
    {
        gameManager.monstersPlaying.Remove(monster);

        for (int i = 0; i < idsMonstersPlaying.Count; i++)
        {
            if (idsMonstersPlaying[i] == selectedMonster.id)
            {
                idsMonstersPlaying.Remove(idsMonstersPlaying[i]);
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
        for (int i = 0; i < gameManager.monstersPlaying.Count; i++)
        {
            idsMonstersPlaying.Add(gameManager.monstersPlaying[i].id);
        }

        numMonster++;

        if (idsMonstersPlaying.Contains(numMonster) == false)
        {
            //RemoveSelectedMonsterFromPlayingMonsters(selectedMonster);
            if (numMonster <= 5)
            {
                selectedMonster = monsters[numMonster];
                monsterImagePlayers.sprite = selectedMonster.monsterPortraitImage;
                monsterNamePlayers.text = selectedMonster.name;
            }
            else
            {
                numMonster = 0;
                selectedMonster = monsters[numMonster];
                monsterImagePlayers.sprite = selectedMonster.monsterPortraitImage;
                monsterNamePlayers.text = selectedMonster.name;
            }


            //AddSelectedMonsterToPlayingMonsters(selectedMonster);
        } else
        {
            NextMonster();
        }
    }

    public void PreviousMonster()
    {
        for (int i = 0; i < gameManager.monstersPlaying.Count; i++)
        {
            idsMonstersPlaying.Add(gameManager.monstersPlaying[i].id);
        }

        numMonster--;

        if (idsMonstersPlaying.Contains(numMonster) == false)
        {
            //RemoveSelectedMonsterFromPlayingMonsters(selectedMonster);
            if (numMonster >= 0)
            {
                selectedMonster = monsters[numMonster];
                monsterImagePlayers.sprite = selectedMonster.monsterPortraitImage;
                monsterNamePlayers.text = selectedMonster.name;
            }
            else
            {
                numMonster = 5;
                selectedMonster = monsters[numMonster];
                monsterImagePlayers.sprite = selectedMonster.monsterPortraitImage;
                monsterNamePlayers.text = selectedMonster.name;
            }

            //AddSelectedMonsterToPlayingMonsters(selectedMonster);
        }
        else
        {
            PreviousMonster();
        }
    }
}
