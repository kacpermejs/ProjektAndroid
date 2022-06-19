using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{

    public GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.triggersCount++;
        gameManager.CheckGameLogic();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        gameManager.triggersCount--;
    }
}
