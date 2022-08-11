using UnityEngine;

public class EnemyController : BaseCharacter
{

    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();

        // Posisi untuk pertama kali 
        Transform();
    }
    private void Update()
    {
        Move();
    }

    public override void Transform()
    {
        xAxis = Random.Range(-2.54f, 2.54f);
        yAxis = 6f;
        pos = new(xAxis, yAxis);
        transform.position = pos;
    }

    public override void Move()
    {
        rig.velocity = Vector2.down * speed;     
    }
}
