using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{
    public TextMeshProUGUI txtScore;
    public TextMeshProUGUI txtHealth;
    // Start is called before the first frame update
    void Start()
    {
     
    }
    public void UpdateScore(int score)
    {
        txtScore.text = score.ToString();
    }
    public void UpdateHealth(int Health){
        txtHealth.text = Health.ToString();
}
    
}
