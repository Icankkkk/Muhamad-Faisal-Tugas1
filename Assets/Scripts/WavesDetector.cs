using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WavesDetector : MonoBehaviour
{
    public ScoreManager scoreManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Debug.Log("detect");
            scoreManager.wavesSystem(1);       
        }
    }

}
