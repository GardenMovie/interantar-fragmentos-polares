using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SlotChecker : MonoBehaviour
{
    public GameObject slot1, slot2, slot3, slot4;
    public Button targetButton;

    void Update()
    {
        bool fullFill =
        slot1.GetComponent<Slot>().SlotFill &&
        slot2.GetComponent<Slot>().SlotFill &&
        slot3.GetComponent<Slot>().SlotFill &&
        slot4.GetComponent<Slot>().SlotFill
        ;
        targetButton.interactable = fullFill;
    }





}