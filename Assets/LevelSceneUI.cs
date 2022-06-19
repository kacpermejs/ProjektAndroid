using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSceneUI : MonoBehaviour
{
    public void NextLevelAction()
    {
        string currentLevelName = SceneManager.GetActiveScene().name;

        int id =  int.Parse(currentLevelName.Replace(Loader.Scene.Level.ToString(), ""));


        Loader.LoadLevel(id+1);
    }

    public void MainMenuAction()
    {
        Loader.Load(Loader.Scene.MainMenu);
    }
}
