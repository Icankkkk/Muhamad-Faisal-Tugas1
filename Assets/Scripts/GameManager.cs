using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private ScoreManager scoreManager;

    private void Update()
    {
        PlayerInput();
    }

    private void PlayerInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CastRay();
        }
    }

    private void CastRay()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (hit)
        {
         
            if (hit.collider.gameObject.CompareTag("Enemy"))
            {
                Debug.Log("hit enemy");
                scoreManager.AddScore(1);
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
