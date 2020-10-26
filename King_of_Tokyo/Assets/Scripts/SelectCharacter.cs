using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCharacter : MonoBehaviour
{
    List<Monster> monsters = new List<Monster>();

    Monster selectedMonster;

    //MonsterDatabase monsterDatabase;

    public Text monsterName;
    public Image monsterImage;

    int numMonster;
    bool changedFirstTime;

    // Start is called before the first frame update
    void Start()
    {
        numMonster = 0;

        monsters = MonsterDatabase.monsterList;

        selectedMonster = monsters[numMonster];
    }

    // Update is called once per frame
    void Update()
    {
            monsterName.text = selectedMonster.name;

            monsterImage.sprite = selectedMonster.monsterImage;
    }

    public void NextMonster()
    {
        if (changedFirstTime != true)
        {
            changedFirstTime = true;
        }

        numMonster++;

        if (numMonster <= 5)
        {
            selectedMonster = monsters[numMonster];
        }
        else
        {
            numMonster = 0;
            selectedMonster = monsters[numMonster];
        }
    }

    public void PreviousMonster()
    {
        if (changedFirstTime != true)
        {
            changedFirstTime = true;
        }


        numMonster--;

        if (numMonster >= 0)
        {
            selectedMonster = monsters[numMonster];
        }
        else
        {
            numMonster = 5;
            selectedMonster = monsters[numMonster];
        }
    }
}
