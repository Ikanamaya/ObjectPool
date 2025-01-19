using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
public class Bullet : AutoDestroyPoolableObject
{
    [HideInInspector]
    public Rigidbody2D RigidBody;
    public Vector2 Speed = new Vector2(200, 0);

    private void Awake()
    {
        RigidBody = GetComponent<Rigidbody2D>();
    }


    public override void OnEnable()
    {
        base.OnEnable();

        RigidBody.linearVelocity = Speed;
    }


    public override void OnDisable()
    {
        base.OnDisable();

        RigidBody.linearVelocity = Vector2.zero;
    }
}
