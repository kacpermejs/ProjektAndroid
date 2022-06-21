using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalManager : MonoBehaviour
{
    public Goal[] goals;

    private int GoalsRemaining = -1;

    public GameObject gameWonCanvas;

    private bool GameEnded = false;

    void Awake()
    {
        goals = GetComponentsInParent<Goal>();
        GoalsRemaining = goals.Length;
    }

    void OnGUI()
    {
        foreach (var goal in goals)
        {
            goal.DrawHUD();
        }
    }

    void Update()
    {
        if(!GameEnded)
        {
            foreach (var goal in goals)
            {
                if (goal.IsAchieved())
                {
                    GoalsRemaining--;
                    goal.Complete();
                    Destroy(goal);
                }
            }
            if (GoalsRemaining <= 0)
            {
                GameEnded = true;
                gameWonCanvas.SetActive(true);
                Time.timeScale = 0.2f;
            }
        }
    }


}

