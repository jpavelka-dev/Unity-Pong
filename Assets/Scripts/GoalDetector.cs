using UnityEngine;

public class GoalDetector : MonoBehaviour
{
    private GameManager gameManager;
    private AudioSource audioSource; // reference na AudioSource

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();        // najdi GameManager ve scéně
        audioSource = GetComponent<AudioSource>();            // najdi AudioSource na tomto objektu
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Circle")
        {
            audioSource.Play(); // přehraj zvuk
            gameManager.GameOver(); // zavolej GameOver místo Time.timeScale
        }
    }
}