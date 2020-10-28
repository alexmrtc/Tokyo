using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDatabase : MonoBehaviour
{
    public static List<Monster> monsterList = new List<Monster>();

    private void Awake()
    {
        monsterList.Add(new Monster(0, "Meca Dragon", 10, 0, 0, false, false, Resources.Load<Sprite>("Monsters/cyberdragon"), Resources.Load<Sprite>("Monsters/mecadragon_portrait")));
        monsterList.Add(new Monster(1, "Alienoid", 10, 0, 0, false, false, Resources.Load<Sprite>("Monsters/alienoid"), Resources.Load<Sprite>("Monsters/alienoid_portrait")));
        monsterList.Add(new Monster(2, "Gigazaur", 10, 0, 0, false, false, Resources.Load<Sprite>("Monsters/gigazaur"), Resources.Load<Sprite>("Monsters/gigazaur_portrait")));
        monsterList.Add(new Monster(3, "Cyber Kitty", 10, 0, 0, false, false, Resources.Load<Sprite>("Monsters/cyberkitty"), Resources.Load<Sprite>("Monsters/cyberkitty_portrait")));
        monsterList.Add(new Monster(4, "The King", 10, 0, 0, false, false, Resources.Load<Sprite>("Monsters/king"), Resources.Load<Sprite>("Monsters/theking_portrait")));
        monsterList.Add(new Monster(5, "Space Penguin", 10, 0, 0, false, false, Resources.Load<Sprite>("Monsters/space_penguin"), Resources.Load<Sprite>("Monsters/spacepenguin_portrait")));

        //for (int i = 0; i < monsterList.Count; i++)
        //{
        //    Debug.Log("Monster: " + monsterList[i].id);
        //    Debug.Log("Name: " + monsterList[i].name);
        //    Debug.Log("Health: " + monsterList[i].health);
        //    Debug.Log("Victory Points: " + monsterList[i].victoryPoints);
        //    Debug.Log("In Tokyo: " + monsterList[i].inTokyo.ToString());
        //    Debug.Log("Dead: " + monsterList[i].dead.ToString());
        //}
    }
}
