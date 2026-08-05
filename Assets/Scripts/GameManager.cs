using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject rightPaddle; // přetáhni pravou pálku v Inspectoru

    void Start()
    {
        gameOverPanel.SetActive(false);
        Time.timeScale = 1f;

        // přečti GameMode z MainMenu
        int mode = PlayerPrefs.GetInt("GameMode");

        if (mode == 0) // Player vs Player
        {
            rightPaddle.GetComponent<AIController>().enabled = false;
            rightPaddle.GetComponent<PaddleController>().enabled = true;
        }
        else // Player vs AI
        {
            rightPaddle.GetComponent<AIController>().enabled = true;
            rightPaddle.GetComponent<PaddleController>().enabled = false;
        }
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Debug.Log("RestartGame zavolán!"); // dočasný test
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }
}