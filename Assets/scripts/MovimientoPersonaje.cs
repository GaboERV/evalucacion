using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientoPersonaje : MonoBehaviour
{
    public float force = 3f;
    private Rigidbody2D rb;
    private Vector2 dir = Vector2.right;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnMove(InputValue value)
    {
        Vector2 input = value.Get<Vector2>();

        if (input.y > 0) 
        {
            rb.linearVelocity= Vector2.zero;
            dir = Vector2.up;
        }
        else if (input.y < 0) 
        {
            rb.linearVelocity= Vector2.zero;
            dir = Vector2.down;
        }
        else 
        {
            rb.linearVelocity= Vector2.zero;
            dir = Vector2.right;
        }
    }

    void FixedUpdate()
    {
        rb.AddForce(dir * force);
    }
}