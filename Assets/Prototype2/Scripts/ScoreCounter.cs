using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public static int score = 0;
    public static int life = 9;
    
    
    public static void ShowScore()
    {
        Debug.Log("Lifes:" + life + " Score:" + score);
    }
    
}
