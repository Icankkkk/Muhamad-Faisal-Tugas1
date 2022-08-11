using UnityEngine;

public abstract class BaseCharacter : MonoBehaviour
{
    [SerializeField] protected float speed = 2f;
    [SerializeField] protected float amplitude = 5.0f;
    [SerializeField] protected float frequency = 1.0f;
    protected Rigidbody2D rig;
    protected Vector2 pos;
    protected Vector2 axis;
    protected float xAxis;
    protected float yAxis;

    public abstract void Move();
    public abstract void Transform();
}
