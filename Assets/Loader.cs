using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Loader
{
    public enum Scene
    {
        MainMenu,
        LoadingScreen,
        Level1,
        Level,
    }

    private static readonly int LastLevelId = 3;

    private static Action onLoaderCallback;

    public static void Load(Scene scene)
    {
        onLoaderCallback = () =>
        {
            SceneManager.LoadScene(scene.ToString());
        };

        SceneManager.LoadScene(Scene.LoadingScreen.ToString());
    }

    public static void LoadLevel(int num)
    {
        onLoaderCallback = () =>
        {
            string name = Scene.Level.ToString() + num;

            if (num <= LastLevelId && num > 0)
            {
                SceneManager.LoadScene(name);
            }
            else
            {
                SceneManager.LoadScene(Scene.MainMenu.ToString());
            }
            
        };

        SceneManager.LoadScene(Scene.LoadingScreen.ToString());
    }

    public static void LoadLevelNoLoadingScreen(int num)
    {
        string name = Scene.Level.ToString() + num;

        if (num <= LastLevelId && num > 0)
        {
            SceneManager.LoadScene(name);
        }
        else
        {
            SceneManager.LoadScene(Scene.MainMenu.ToString());
        }
    }

    public static void LoaderCallback()
    {
        if(onLoaderCallback != null)
        {
            onLoaderCallback();
            onLoaderCallback = null;
        }
    }
}
