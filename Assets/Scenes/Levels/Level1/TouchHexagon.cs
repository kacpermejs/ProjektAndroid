using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchHexagon : Goal
{
    public int HexagonsTouched = 0;
    public int HexagonsRequired = 2;

    public GameObject gameWonCanvas;
    public bool gameEnded = false;

    private void Start()
    {
        Time.timeScale = 1;
    }

    public override void Complete()
    {
        gameEnded = true;
        gameWonCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public override void DrawHUD()
    {
        
    }

    public override bool IsAchieved()
    {
        return HexagonsTouched >= HexagonsRequired;
    }

    
}
