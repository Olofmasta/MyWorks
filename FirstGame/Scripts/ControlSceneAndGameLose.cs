using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ControlSceneAndGameLose : MonoBehaviour
{
    public GameObject buttonRetry;
    public GameObject buttonMenu;
    public GameObject buttonExit;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewGameLoadScenceAndreiMatusevichGame()
    {
        Application.LoadLevel("AndreiMatusevichGame");
    }

    public void MainMenu()
    {
        Application.LoadLevel("Menu");
    }

    public void ExitGame()
    {
        EditorApplication.isPaused = true;
        Application.Quit();
    }
}
