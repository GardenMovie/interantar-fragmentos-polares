using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class Slot : MonoBehaviour, IDropHandler
{
    public bool inventory = false;
    public bool SlotFill = false;
    public int slotValue;

    void Update()
    {
        SlotFill = (transform.childCount == 0) ? false : true;
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Test");
        GameObject dropped = eventData.pointerDrag;
        Draggableitem draggableitem = dropped.GetComponent<Draggableitem>();
        if (transform.childCount == 0 || inventory == true)
        {
            draggableitem.parentAfterDrag = transform;
        }
        else
        {
            Draggableitem existingItem = GetComponentInChildren<Draggableitem>();
            gameManager.Instance.listIDs.Remove(existingItem.idImg);
            existingItem.parentAfterDrag = draggableitem.parentAfterDrag;
            draggableitem.parentAfterDrag = transform;
            existingItem.OnEndDrag(eventData);
        }
        slotValue = draggableitem.addScore;
        if (inventory == false)
        {
            gameManager.Instance.listIDs.Add(draggableitem.idImg);
        }
    }
}
