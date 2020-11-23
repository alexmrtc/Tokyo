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
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        //for (int i = 0; i < gameManager.monstersPlaying.Count; i++)
        //{
        //    idsMonstersPlaying.Add(gameManager.monstersPlaying[i].id);
        //}
    }

    private void Init()
    {
        monsters = MonsterDatabase.monsterList;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void GenerateRandomNumberNotExisting()
    {
        do
        {
            numMonster = Random.Range(0, 6);
        } while (gameManager.idsMonstersPlaying.Contains(numMonster));
    }

    public void AssignMonsterFromSelector(int id)
    {
        Init();

        numMonster = id;

        activateButton.SetActive(false);
        deactivateButton.SetActive(true);

        Debug.Log("Size Monsters: " + monsters.Count);
        selectedMonster = monsters[numMonster];

        gameManager.AddSelectedMonsterToPlayingMonsters(selectedMonster);

        monsterImagePlayers.sprite = selectedMonster.monsterPortraitImage;
        monsterNamePlayers.text = selectedMonster.name;

        monsterActive = true;

        nextButton.SetActive(true);
        previousButton.SetActive(true);
    }

    public void ActivateMonster()
    {
        GenerateRandomNumberNotExisting();

        activateButton.SetActive(false);
        deactivateButton.SetActive(true);

        selectedMonster = monsters[numMonster];

        gameManager.AddSelectedMonsterToPlayingMonsters(selectedMonster);

        monsterImagePlayers.sprite = selectedMonster.monsterPortraitImage;
        monsterNamePlayers.text = selectedMonster.name;

        monsterActive = true;

        nextButton.SetActive(true);
        previousButton.SetActive(true);
    }

    public void DeactivateMonster()
    {
        gameManager.RemoveSelectedMonsterFromPlayingMonsters(selectedMonster);

        activateButton.SetActive(true);
        deactivateButton.SetActive(false);

        nextButton.SetActive(false);
        previousButton.SetActive(false);

        monsterNamePlayers.text = "";

        monsterActive = false;
    }

    public void NextMonster()
    {
        numMonster++;

        while (gameManager.idsMonstersPlaying.Contains(numMonster) == true)
        {
            numMonster++;

            if (numMonster > 5)
            {
                numMonster = 0;
                if (gameManager.idsMonstersPlaying.Contains(numMonster))
                {
                    NextMonster();
                }
            }
        }


        if (gameManager.idsMonstersPlaying.Contains(numMonster) == false)
        {
            gameManager.RemoveSelectedMonsterFromPlayingMonsters(selectedMonster);

            //gameManager.idsMonstersPlaying[1] = numMonster;

            selectedMonster = monsters[numMonster];
            monsterImagePlayers.sprite = selectedMonster.monsterPortraitImage;
            monsterNamePlayers.text = selectedMonster.name;

            gameManager.AddSelectedMonsterToPlayingMonsters(selectedMonster);
        }
        else
        {
            if (gameManager.idsMonstersPlaying.Count > 6)
            {
                numMonster++;
            }
        }

    }

    public void PreviousMonster()
    {
        numMonster--;

        while (gameManager.idsMonstersPlaying.Contains(numMonster) == true)
        {
            numMonster--;
            if (numMonster < 0)
            {
                numMonster = 5;

                if (gameManager.idsMonstersPlaying.Contains(numMonster))
                {
                    PreviousMonster();
                }
            }
        }

        if (gameManager.idsMonstersPlaying.Contains(numMonster) == false)
        {
            gameManager.RemoveSelectedMonsterFromPlayingMonsters(selectedMonster);

            selectedMonster = monsters[numMonster];
            monsterImagePlayers.sprite = selectedMonster.monsterPortraitImage;
            monsterNamePlayers.text = selectedMonster.name;

            gameManager.AddSelectedMonsterToPlayingMonsters(selectedMonster);
        }
        else
        {
            if (gameManager.idsMonstersPlaying.Count > 6)
            {
                PreviousMonster();
            }
        }
    }
}
