using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    public void PlayButtonAction()
    {
        //Debug.Log("click");
        Loader.Load(Loader.Scene.Level1);
    }
}
