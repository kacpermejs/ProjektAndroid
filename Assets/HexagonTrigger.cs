using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexagonTrigger : MonoBehaviour
{
    public TouchHexagon goalScript;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (string.Equals(collision.tag, "Player"))
            goalScript.HexagonsTouched++;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (string.Equals(collision.tag, "Player"))
            goalScript.HexagonsTouched--;
    }
}
