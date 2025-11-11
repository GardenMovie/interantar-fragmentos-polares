using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections; // if using TextMeshPro

public class TextFader : MonoBehaviour
{
    public CanvasGroup canvasGroup; // assign in inspector
    public float fadeDuration = 1f;

    private void Awake()
    {
        if (canvasGroup == null)
            canvasGroup = GetComponent<CanvasGroup>();
    }

    public void ShowText(string message)
    {
        // Set text
        var text = GetComponent<TextMeshProUGUI>();
        if (text != null) text.text = message;
        else
        {
            var utext = GetComponent<Text>();
            if (utext != null) utext.text = message;
        }

        StopAllCoroutines();
        StartCoroutine(FadeInOut());
    }

    private IEnumerator FadeInOut()
    {
        // Fade in
        for (float t = 0; t < fadeDuration; t += Time.deltaTime)
        {
            canvasGroup.alpha = t / fadeDuration;
            yield return null;
        }
        canvasGroup.alpha = 1f;

        // Stay visible for 2 seconds (or adjust)
        yield return new WaitForSeconds(2f);

        // Fade out
        for (float t = 0; t < fadeDuration; t += Time.deltaTime)
        {
            canvasGroup.alpha = 1 - (t / fadeDuration);
            yield return null;
        }
        canvasGroup.alpha = 0f;
    }
}
