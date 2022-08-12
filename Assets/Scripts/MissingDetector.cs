using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissingDetector : MonoBehaviour
{
    private  ScoreManager scoreManager;
  
    private void Start()
    {
        scoreManager = GameObject.Find("Score Manager").GetComponent<ScoreManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Debug.Log("missing");
            scoreManager.MissingScore(1);
            Destroy(collision.gameObject);
        }
    }
}
