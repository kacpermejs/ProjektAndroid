using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSceneUI : MonoBehaviour
{
    public GameObject PopUpMenuCanvas;

    public void NextLevelAction()
    {
        string currentLevelName = SceneManager.GetActiveScene().name;

        int id =  int.Parse(currentLevelName.Replace(Loader.Scene.Level.ToString(), ""));


        Loader.LoadLevel(id+1);
    }

    public void ReloadLevelAction()
    {
        string currentLevelName = SceneManager.GetActiveScene().name;

        int id = int.Parse(currentLevelName.Replace(Loader.Scene.Level.ToString(), ""));

        Loader.LoadLevelNoLoadingScreen(id);
    }

    public void MainMenuAction()
    {
        Loader.Load(Loader.Scene.MainMenu);
    }

    public void PopupMenuEnableAction()
    {
        if(!PopUpMenuCanvas.activeSelf)
        {
            Time.timeScale = 0;
            PopUpMenuCanvas.SetActive(true);
        }
        else
        {
            PopUpMenuCanvas.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
