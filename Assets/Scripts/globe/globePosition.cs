using UnityEngine;
using UnityEngine.InputSystem; // Required for the new Input System

public class GlobePosition : MonoBehaviour
{
    public Vector3[] positionTargets;
    int currentTargetIndex = 0;

    void Start()
    {
        if (positionTargets == null || positionTargets.Length == 0)
        {
            positionTargets = new Vector3[]
            {
                new Vector3(0f, 0f, 0f),
                new Vector3(-670f, 0f, 0f),
            };
        }
    }

    void Update()
    {
        // Detect mouse or touch input
        bool tapped = 
            (Touchscreen.current != null && Touchscreen.current.primaryTouch.press.wasPressedThisFrame)
            || (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame);

        if (tapped)
        {
            currentTargetIndex++;

            if (currentTargetIndex >= positionTargets.Length)
                currentTargetIndex = positionTargets.Length;

            Debug.Log("Switched to position index: " + currentTargetIndex);
        }
        else
        {
            Vector3 targetPosition = positionTargets[currentTargetIndex];
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, targetPosition, 500f * Time.deltaTime);
        }
    }
}
