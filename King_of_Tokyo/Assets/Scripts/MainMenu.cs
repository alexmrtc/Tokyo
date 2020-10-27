using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject playerSelect;
    public GameObject mainMenu;
    public GameObject players;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToPlayerSelect()
    {
        playerSelect.SetActive(true);
        players.SetActive(false);
        mainMenu.SetActive(false);
    }

    public void GoToPlayers()
    {
        playerSelect.SetActive(false);
        players.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void GoToMainMenu()
    {
        playerSelect.SetActive(false);
        players.SetActive(false);
        mainMenu.SetActive(true);
    }
}
