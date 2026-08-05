using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 5f;
    public GameObject impactEffectPrefab; // sem přiřadíme Prefab v Inspectoru

    private Rigidbody2D rb;
    private AudioSource audioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();

        rb.linearVelocity = new Vector2(1, 1) * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioSource.Play();

        // vytvoř kopii efektu na pozici míčku
        Instantiate(impactEffectPrefab, transform.position, Quaternion.identity);
    }
}