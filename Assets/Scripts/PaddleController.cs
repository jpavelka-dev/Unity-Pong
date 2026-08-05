using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float speed = 5f;
    public string inputAxis = "Vertical"; // jakou osu čte tato pálka

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float direction = Input.GetAxis(inputAxis);
        rb.linearVelocity = new Vector2(0, direction * speed);
    }
}