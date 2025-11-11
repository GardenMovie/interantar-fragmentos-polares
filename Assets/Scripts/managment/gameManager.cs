using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    [Header("Audio Source")]
    [SerializeField] public AudioSource musicSource;
    [SerializeField] public AudioSource SFXSource;

    [Header("Audio Clip")]
    public AudioClip backgroundSpace;
    public AudioClip backgroundWind;
    public AudioClip clickIn;
    public AudioClip clickOut;
    public AudioClip finish;

    public static gameManager Instance;

    [Header("Game Values")]
    public int score;
    public int permScore;
    public string cenaAtual;
    public int globeTargetIndex = -1;
    public int addNext = 0;
    public List<int> listIDs = new List<int>();

    public int currentState { get; internal set; }
    public bool soundOn = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void setTargetIndex(int i)
    {
        globeTargetIndex = i;
    }

    public void setAddNext(int i)
    {
        addNext = i;
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        cenaAtual = scene.name;
        //globeTargetIndex += addNext;
        //addNext = 0;
        Debug.Log("Scene loaded: " + scene.name + ". globeTargetIndex reset.");
        listIDs.Clear();
        permScore += score;
        score = 0;

        if (cenaAtual == "mainMenu")
        {
            permScore = 0;
        }

        if (soundOn == true)
        {
            musicSource.clip = (cenaAtual == "globo") ? backgroundSpace : backgroundWind;

            musicSource.Play();

            if (cenaAtual == "mainMenu" || cenaAtual == "finalMenu")
            {
                musicSource.Stop();
            }
        }
        if (cenaAtual == "finalMenu") PlaySFX(finish);
    }


    void Start()
    {
        score = 0;
    }

    void Update()
    {
        // Works on mobile (touch) and mouse (for testing in editor)
        /*         bool tapped =
                    (Touchscreen.current != null && Touchscreen.current.primaryTouch.press.wasPressedThisFrame)
                    || (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame);

                if (tapped && cenaAtual == "globo")
                {
                    if (globeTargetIndex == 2 && addNext != 1)
                    {
                        ChangeScene("intAntart");
                        addNext = 1;
                        return;
                    }
                    globeTargetIndex++;

                    Debug.Log("globeTargetIndex is: " + globeTargetIndex);

                } */

    }

    public void incrementIndex()
    {
        if (globeTargetIndex == 1 && addNext == 0)
        {
            ChangeScene("outArt");
            addNext = 1;
            return;
        } 
        if (globeTargetIndex == 2 && addNext == 1)
        {
            ChangeScene("intArt");
            addNext = 2;
            return;
        }
        if (globeTargetIndex == 3 && addNext == 2)
        {
            ChangeScene("outAntart");
            addNext = 3;
            return;
        } 
        if (globeTargetIndex == 4 && addNext == 3)
        {
            ChangeScene("intAntart");
            addNext = 4;
            return;
        } 
        if (globeTargetIndex == 5 && addNext == 4)
        {
            ChangeScene("outAntAntart");
            addNext = 5;
            return;
        } 
        globeTargetIndex++;

        Debug.Log("globeTargetIndex is: " + globeTargetIndex);
    }

    public void ChangeScene(string nomeCena)
    {
        SceneManager.LoadScene(nomeCena);
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }

    

}
