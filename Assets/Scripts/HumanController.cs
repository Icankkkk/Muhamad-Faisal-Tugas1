
using UnityEngine;

public class HumanController : BaseCharacter
{
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        // Posisi awal
        axis = transform.right;
        Transform();
    }

    private void Update()
    {
        Move();
    }

    public override void Transform()
    {
        xAxis = Random.Range(-1.54f, 1.54f);
        yAxis = 6;
        pos = new(xAxis, yAxis);
        transform.position = pos;
    }

    public override void Move()
    {
        pos += speed * Time.deltaTime * Vector2.down;
        transform.position = pos + amplitude * Mathf.Sin(Time.time * frequency) * axis; 
        //rig.velocity = Vector2.down * speed;
    }
}
