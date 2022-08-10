using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int playerScore;
    public int playerMissing;


    public void addScore(int i)
    {
        playerScore += i;  
    }

    public void missingScore(int i)
    {
        playerMissing += i;
    } 
    
}
