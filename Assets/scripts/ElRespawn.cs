using UnityEngine;

public class ElRespawn : MonoBehaviour
{
    public string pared = "pared";
    private Vector3 inicio;
    private Rigidbody2D rb;

    void Start()
    {
        inicio = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        ChecarPared(collision.gameObject);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        ChecarPared(collision.gameObject);
    }

    void ChecarPared(GameObject obj)
    {
        if (obj.layer == LayerMask.NameToLayer(pared))
        {
            transform.position = inicio;
            if (rb != null) rb.linearVelocity = Vector2.zero;
        }
    }
}