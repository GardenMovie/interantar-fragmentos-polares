using UnityEngine;

public class gridScoreMan : MonoBehaviour
{
    public int totalScore;
    void Update()
    {
        totalScore = 0;
        Draggableitem[] childScripts = GetComponentsInChildren<Draggableitem>();
        foreach (Draggableitem item in childScripts)
        {
            totalScore += item.addScore;
        }
        gameManager.Instance.score = totalScore;
    }
}
