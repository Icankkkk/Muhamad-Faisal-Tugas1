using UnityEngine;

public class Detector : MonoBehaviour
{
    public ScoreManager scoreManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Debug.Log("detect");
            scoreManager.WavesSystem(1);
        }      
    }
}
