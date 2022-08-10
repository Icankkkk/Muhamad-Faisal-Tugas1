using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //double walkingSpeed;
    float x;
    Vector2 pos;
    public float speed;
    private new Rigidbody2D rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        // Place the enemy in random position
        x = Random.Range(-2.54f, 2.54f);
        pos = new Vector2(x, 6);
        transform.position = pos;     
        
        rigidbody2D  = GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = Vector2.down * speed;
    }
}
