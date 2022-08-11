using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject[] enemy;
    public float spawnTime = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(Spawn), spawnTime, spawnTime);
    }


    void Spawn()
    {

        for (int i = 0; i < enemy.Length; i++)
        {
            Instantiate(enemy[i]);
        }
    }
}
