﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{
    public TextMeshProUGUI txtScore;
    // Start is called before the first frame update
    void Start()
    {
        txtScore.text = "0";
    }
    public void UpdateScore(int score)
    {
        txtScore.text = score.ToString();
    }
}
