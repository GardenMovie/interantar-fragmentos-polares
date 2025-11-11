using Unity.VisualScripting;
using UnityEngine;

public class navButton : MonoBehaviour
{
    public int globalTargetSet;
    public int addNextSet;
    public string sceneSet;
    public AudioClip click;

    public void OnButtonClicked()
    {
        gameManager.Instance.PlaySFX(click);
        if (sceneSet == "")
        {
            return;
        }
        gameManager.Instance.globeTargetIndex = globalTargetSet;
        gameManager.Instance.addNext = addNextSet;
        gameManager.Instance.ChangeScene(sceneSet);
    }
}