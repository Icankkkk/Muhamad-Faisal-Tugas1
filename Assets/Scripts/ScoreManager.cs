using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int playerScore;
    public int playerMissing;
    public int wavesScore;
    public int wavesResult;

    public void addScore(int i)
    {
        playerScore += i;  
    }

    public void missingScore(int i)
    {
        playerMissing += i;
    } 

    public void wavesSystem(int i)
    {
        if (wavesScore == 10)
        {
            wavesScore = 0;
            wavesResult += i;
        } else {
            wavesScore += i;
        }
    }
    
}
