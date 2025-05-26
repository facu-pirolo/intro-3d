using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public UiManager uiManager;
    // Start is called before the first frame update
    void Start()
    {
        uiManager = FindObjectOfType<UiManager>();
        score = 0;
    }

   public void AddScore()
    {
        score ++;
        uiManager.UpdateScore(score);
    }
    public void AddScore(int ScorePoints)
    {
        score += ScorePoints;
        uiManager.UpdateScore(score);
    }
}
