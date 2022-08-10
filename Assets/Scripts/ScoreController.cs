using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public TMP_Text score;
    public TMP_Text missing;
    public TMP_Text waves;

    public ScoreManager scoreManager;

    private void Update()
    {
        score.text = "Score: " + scoreManager.playerScore.ToString();
        missing.text = "Missing: " + scoreManager.playerMissing.ToString();
        waves.text = "Waves: " + scoreManager.wavesResult.ToString();
    }
}
