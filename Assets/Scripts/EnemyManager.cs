using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject enemy;
    public float spawnTime = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }


    void Spawn()
    {
        Instantiate(enemy);
    }
}
