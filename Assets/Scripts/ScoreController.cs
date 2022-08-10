using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public TMP_Text score;
    public TMP_Text missing;
    public ScoreManager manager;

    private void Update()
    {
        score.text = "Score: " + manager.playerScore.ToString();
        missing.text = "Missing: " + manager.playerMissing.ToString();
    }
}
