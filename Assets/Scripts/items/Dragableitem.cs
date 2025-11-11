using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Draggableitem : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public Image image;
    private int index;
    public int addScore;
    public int idImg;
    public Transform initParent;

    gameManager audioManager;

    void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<gameManager>();
    }

    void Start()
    {
        initParent = transform.parent;
    }

    /*[HideInInspector]*/ public Transform parentAfterDrag;
    public void OnBeginDrag(PointerEventData eventData)
    {
        audioManager.PlaySFX(audioManager.clickOut);
        index = transform.GetSiblingIndex();
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        RectTransform rt = GetComponent<RectTransform>();
        rt.sizeDelta = new Vector2(150, 150);
        image.raycastTarget = false;
        audioManager.listIDs.Remove(idImg);
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position; 
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        audioManager.PlaySFX(audioManager.clickIn);
        index = transform.GetSiblingIndex();
        transform.SetParent(parentAfterDrag);
        transform.SetSiblingIndex(index);
        image.raycastTarget = true;
    }
}
