using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchHexagon : Goal
{
    public int HexagonsTouched = 0;
    public int HexagonsRequired = 2;

    private void Start()
    {
        Time.timeScale = 1;
    }

    public override void Complete()
    {
        
    }

    public override void DrawHUD()
    {
        
    }

    public override bool IsAchieved()
    {
        return HexagonsTouched >= HexagonsRequired;
    }

    
}
