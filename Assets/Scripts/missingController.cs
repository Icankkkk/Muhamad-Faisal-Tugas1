using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missingController : MonoBehaviour
{
    public ScoreManager scoreManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag ("Enemy"))
        {
            scoreManager.missingScore(1);
            Destroy(collision.gameObject);
        }
    }
       
}
