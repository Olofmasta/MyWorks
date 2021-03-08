using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ControlSceneAndMenu : MonoBehaviour
{
    public GameObject buttonsMenu;
    public GameObject buttonsExit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 
    public void ShowExitButtons()
    {
        buttonsMenu.SetActive(false);
        buttonsExit.SetActive(true);
    }

    public void BackInMenu()
    {
        buttonsMenu.SetActive(true);
        buttonsExit.SetActive(false);
    }

    public void ExitGame()
    {
        EditorApplication.isPaused = true;
        Application.Quit();
    }

    public void NewGameLoadScenceAndreiMatusevichGame()
    {
        Application.LoadLevel ("AndreiMatusevichGame");
    }
}
