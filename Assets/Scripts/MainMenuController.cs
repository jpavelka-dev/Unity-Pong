using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // zavolá se když hráč klikne "Hráč vs Hráč"
    public void PlayPlayerVsPlayer()
    {
        // uložíme výběr aby hra věděla jaký režim spustit
        PlayerPrefs.SetInt("GameMode", 0);
        SceneManager.LoadScene("SampleScene");
    }

    // zavolá se když hráč klikne "Hráč vs AI"
    public void PlayPlayerVsAI()
    {
        PlayerPrefs.SetInt("GameMode", 1);
        SceneManager.LoadScene("SampleScene");
    }

    // zavolá se když hráč klikne "Ukončit"
    public void QuitGame()
    {
        Application.Quit();
    }
}