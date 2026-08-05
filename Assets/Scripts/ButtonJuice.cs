using UnityEngine;
using TMPro; // NUTNÉ: Umožní skriptu pracovat s TextMeshPro textem

public class ButtonJuice : MonoBehaviour
{
    private Vector3 originalScale;
    private Vector3 targetScale;

    [Header("Text Configuration")]
    public TextMeshProUGUI buttonText; // Sem v Unity přetáhneš text tlačítka

    // V základu bude text svítit azurově (#06B6D4)
    private Color normalColor = new Color(0.02f, 0.71f, 0.83f);

    // Při najetí myší (hover) text zbělá (#FFFFFF)
    private Color hoverColor = Color.white;


    void Start()
    {
        originalScale = transform.localScale;
        targetScale = originalScale;

        // Nastavíme textu výchozí barvu hned na startu
        if (buttonText != null)
        {
            buttonText.color = normalColor;
        }
    }

    void Update()
    {
        // Plynulé zvětšování/zmenšování
        transform.localScale = Vector3.Lerp(transform.localScale, targetScale, Time.unscaledDeltaTime * 15f);
    }

    public void OnHoverEnter()
    {
        targetScale = originalScale * 1.05f;

        // Když myš najede na tlačítko, text zbělá
        if (buttonText != null)
        {
            buttonText.color = hoverColor;
        }
    }

    public void OnHoverExit()
    {
        targetScale = originalScale;

        // Když myš odejde, text se vrátí na původní barvu
        if (buttonText != null)
        {
            buttonText.color = normalColor;
        }
    }
}