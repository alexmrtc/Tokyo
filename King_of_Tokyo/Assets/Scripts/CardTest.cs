using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardTest : MonoBehaviour
{

    protected GameManager gameManager;
    public CardFunctions cardFunctions;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CallGameManagerBuy()
    {
        gameManager.CheckMonsterCanAfford();
    }

    public void UseCardFunction()
    {
        cardFunctions.Use();
    }
}
