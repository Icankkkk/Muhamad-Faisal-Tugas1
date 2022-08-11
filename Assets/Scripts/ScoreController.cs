using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    [SerializeField] private  ScoreManager scoreManager;

    public TMP_Text score;
    public TMP_Text missing;
    public TMP_Text waves;

    private void Update()
    {
        ShowInfo();   
    }


    private void ShowInfo()
    {
        score.text = "Score: " + scoreManager.playerScore.ToString();
        missing.text = "Missing: " + scoreManager.playerMissing.ToString();
        waves.text = "Waves: " + scoreManager.wavesResult.ToString();
    }
}
