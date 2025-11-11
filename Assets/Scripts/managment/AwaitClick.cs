using UnityEngine;
using UnityEngine.UI;

public class AwaitClick : MonoBehaviour
{
    public bool clicked = false;
    public Button BtnObject;

    void Start()
    {
        BtnObject.interactable = false;
        BtnObject = transform.parent.GetComponent<Button>();
        BtnObject.onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        clicked = true;
        BtnObject.interactable = false;
    }
}
