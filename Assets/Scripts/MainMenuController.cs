using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{

    public void startGame()
    {
        Application.LoadLevel("GamePlay");
    }

    public void optionMenu()
    {
        Application.LoadLevel("OptionMenu");
    }
    public void gamePause()
    {
        Application.LoadLevel("PauseMenu");
    }

    public void Home()
    {
        Application.LoadLevel("MainMenu");
    }

    public void back()
    {
        Application.LoadLevel("GamePlay");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
