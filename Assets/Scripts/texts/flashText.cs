using TMPro;
using UnityEngine;


public class flashText : MonoBehaviour
{
    public TextMeshProUGUI flashingText;
    public CanvasGroup canvasGroup;

    private float theta;
    public float flashSpeed;

    void Update()
    {
        theta += flashSpeed * Time.deltaTime;
        canvasGroup.alpha = Mathf.Abs(Mathf.Sin(theta)/2);
    }
}
