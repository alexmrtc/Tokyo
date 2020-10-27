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

    int numMonster;

    // Start is called before the first frame update
    void Start()
    {
        monsters = MonsterDatabase.monsterList;

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ActivateMonster()
    {
        numMonster = Random.Range(0, 5);

        activateButton.SetActive(false);
        deactivateButton.SetActive(true);

        selectedMonster = monsters[numMonster];

        monsterImagePlayers.sprite = selectedMonster.monsterPortraitImage;
        monsterNamePlayers.text = selectedMonster.name;

        monsterActive = true;

        nextButton.SetActive(true);
        previousButton.SetActive(true);
    }

    public void DeactivateMonster()
    {
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
    }

    public void PreviousMonster()
    {
        numMonster--;

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
    }
}
