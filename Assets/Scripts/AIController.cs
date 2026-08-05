using UnityEngine;

public class AIController : MonoBehaviour
{
    public float speed = 5f;
    public Transform ball;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
    }

    void FixedUpdate()
    {
        if (ball.position.y > transform.position.y)
        {
            // míček je výš → jdi nahoru
            rb.linearVelocity = new Vector2(0, speed);
        }
        else if (ball.position.y < transform.position.y)
        {
            // míček je níž → jdi dolů
            rb.linearVelocity = new Vector2(0, -speed);
        }
        else
        {
            // míček je na stejné výšce → stůj
            rb.linearVelocity = Vector2.zero;
        }
    }
}
