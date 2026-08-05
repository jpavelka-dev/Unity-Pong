using UnityEngine;

public class MenuFadeIn : MonoBehaviour
{
    private CanvasGroup canvasGroup;
    public float fadeSpeed = 2.5f; // Zde opraveno z px na f

    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.alpha = 0f;
    }

    void Update()
    {
        if (canvasGroup.alpha < 1f)
        {
            canvasGroup.alpha += Time.deltaTime * fadeSpeed;
        }
    }
}