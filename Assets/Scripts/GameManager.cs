using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ScoreManager scoreManager;

    private void Update()
    {
        PlayerInput();
    }

    void PlayerInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CastRay();
        }
    }

    void CastRay()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (hit)
        {
            Collider2D[] hitColliders = Physics2D.OverlapBoxAll(hit.point, new Vector2(100, 100), 0f);
            
            if (hit.collider.gameObject.tag == "Enemy")
            {
                Debug.Log("hit enemy");
                scoreManager.addScore(1);
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
