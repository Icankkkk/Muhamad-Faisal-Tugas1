using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int playerScore;
    public int playerMissing;
    public int wavesScore;
    public int wavesResult;

    public void AddScore(int i)
    {
        playerScore += i;  
    }

    public void MissingScore(int i)
    {
        playerMissing +=i;
    } 

    public void WavesSystem(int i)
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
