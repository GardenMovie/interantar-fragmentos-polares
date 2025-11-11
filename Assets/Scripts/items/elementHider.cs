using UnityEngine;

public class elementHider : MonoBehaviour
{
    public GameObject placaArt;
    public int hideIndexArt;
    public GameObject placaAntArt;
    public int hideIndexAntArt;
    public GameObject placaAntartArt;
    public int hideIndexAntartArt;
    // Update is called once per frame
    void Update()
    {
        int currentIndex = gameManager.Instance.globeTargetIndex;

        if (currentIndex == hideIndexArt)
        {
            Debug.Log("art");
            placaAntArt.SetActive(false);
            placaArt.SetActive(true);
            placaAntartArt.SetActive(false);
        }
        else if (currentIndex == hideIndexAntartArt)
        {
            Debug.Log("antartart");
            placaArt.SetActive(false);
            placaAntArt.SetActive(false);
            placaAntartArt.SetActive(true);
        }
        else if (currentIndex == hideIndexAntArt)
        {
            Debug.Log("antart");
            placaArt.SetActive(false);
            placaAntArt.SetActive(true);
            placaAntartArt.SetActive(false);
        }
        else
        {
            placaArt.SetActive(false);
            placaAntArt.SetActive(false);
            placaAntartArt.SetActive(false);
        }
    }
}
