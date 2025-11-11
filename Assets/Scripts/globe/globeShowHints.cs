using TMPro;
using UnityEngine;
public class globeShowHints : MonoBehaviour
{
    public GameObject hints; 
    public GameObject arctic; 
    public GameObject antart;
    public GameObject brasil;

    void Update()
    {
        if (gameManager.Instance.cenaAtual != "globo")
        {
            arctic.SetActive(false);
            antart.SetActive(false);
            hints.SetActive(true);
            return;
        }

        hints.SetActive(false);

        switch (gameManager.Instance.globeTargetIndex)
        {
            case 1:
                arctic.SetActive(true);
                antart.SetActive(false);
                break;
            case 3:
                antart.SetActive(true);
                arctic.SetActive(false);
                break;
            default:
                arctic.SetActive(false);
                antart.SetActive(false);
                break;
        }
    }
}
