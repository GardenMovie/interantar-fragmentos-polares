using UnityEngine;

public class openLink : MonoBehaviour
{
    public string linkText;

    public void link(string linkText)
    {
        ConfirmPanel.Instance.Show("Tem certeza que deseja abrir esse link?", linkText);
/*         Application.OpenURL(linkText);
        Debug.Log(linkText + "opened"); */
    }
}
