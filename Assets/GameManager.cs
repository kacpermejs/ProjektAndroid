using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    
    public GameObject gameWonCanvas;

    public List<GameObject> triggers;

    public int triggersCount = 0;
    public bool gameEnded = false;

    private void Start()
    {
        Time.timeScale = 1;
        GetTriggers();
    }

    public void CheckGameLogic()
    {
        if(triggers.Count == triggersCount)
        {
            if(!gameEnded)
            {
                gameEnded = true;
                Debug.Log("win");
                GameWon();
            }
        }
    }

    

    public void GameWon()
    {
        gameWonCanvas.SetActive(true);
        Time.timeScale = 0;
    }


    void GetTriggers()
    {
        GameObject[] triggerObjects = GameObject.FindGameObjectsWithTag("Finish");

        for (int i = 0; i < triggerObjects.Length; i++)
        {
            triggers.Add(triggerObjects[i]);
        }
    }
}
