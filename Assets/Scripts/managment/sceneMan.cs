using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class score_man : MonoBehaviour
{
    public TMP_Text scoreText;
    public GameObject gridSlot;
    private int score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Pontuação: " + gameManager.Instance.permScore.ToShortString()+"/17";
    }
    public void onTeste()
    {
        score += 100;
    }
    public void changeScore(int x)
    {
        score = x;
    }
}
