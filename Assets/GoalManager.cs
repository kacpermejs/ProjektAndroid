using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalManager : MonoBehaviour
{
    public Goal[] goals;

    void Awake()
    {
        goals = GetComponentsInParent<Goal>();
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
        foreach (var goal in goals)
        {
            if (goal.IsAchieved())
            {
                goal.Complete();
                Destroy(goal);
            }
        }
    }
}

