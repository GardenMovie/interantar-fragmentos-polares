using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem; // Required for the new Input System

public class ExampleScript : MonoBehaviour
{
    public Quaternion[] rotationTargets;
    int currentTargetIndex = -1;

    float tiltAroundX = 1f;
    Quaternion dynamicRotation;

    /* start -110 0 90 */
    void Start()
    {
        //transform.rotation = Quaternion.Euler(-110f, 0f, 90f);
        
        if (rotationTargets == null || rotationTargets.Length == 0)
        {
            rotationTargets = new Quaternion[]
            {
                Quaternion.Euler(-50f, 0f, 290f), //Point to Brazil
                Quaternion.Euler(206f, 4f, 290f), //Point Antart
                Quaternion.Euler(206f, 4f, 290f), //Point Antart
                Quaternion.Euler(24f, 0f, 290f), //Point Antart
                Quaternion.Euler(24f, 0f, 290f), //Point Antart
            };
        }
    }

void Update()
{
    currentTargetIndex = gameManager.Instance.globeTargetIndex;

    if (currentTargetIndex >= rotationTargets.Length)
        currentTargetIndex = rotationTargets.Length -1;

    if (currentTargetIndex == -1)
        {
            tiltAroundX += 50f * Time.deltaTime;
            dynamicRotation = Quaternion.Euler(-110f, tiltAroundX, 90f);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, dynamicRotation, 50f * Time.deltaTime);
        }
    else
        {
            Quaternion target = rotationTargets[currentTargetIndex];
            transform.rotation = Quaternion.RotateTowards(transform.rotation, target, 50f * Time.deltaTime);
        }
}

}
