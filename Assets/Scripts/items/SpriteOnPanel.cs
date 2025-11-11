using UnityEngine;
using UnityEngine.UI;

public class SpriteOnPanel : MonoBehaviour
{
    public int myID;
    private SpriteRenderer image;

    void Start()
    {
        image = GetComponent<SpriteRenderer>();
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
