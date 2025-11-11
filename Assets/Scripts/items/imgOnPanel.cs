using UnityEngine;
using UnityEngine.UI;

public class imgOnPanel : MonoBehaviour
{
    public int myID;
    private Image image;

    void Start()
    {
        image = GetComponent<Image>();
        UpdateVisibility();
    }

    void Update()
    {
        UpdateVisibility(); // or call this manually when the list changes
    }

    void UpdateVisibility()
    {
        bool isVisible = gameManager.Instance.listIDs.Contains(myID);
        image.enabled = isVisible;
    }
}
