using System.Xml;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashChange : MonoBehaviour
{
    public void Start()
    {
        SceneManager.LoadScene("mainMenu");
    }
}
