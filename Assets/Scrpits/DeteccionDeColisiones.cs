using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionDeColisiones : MonoBehaviour
{
    public ScoreManager scoreManager;
    public MercaderiaScripts mercaderiaScript;
    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        mercaderiaScript = GetComponent<MercaderiaScripts>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "SimpleFPSController")
        {
            Destroy(gameObject);
            scoreManager.AddScore(mercaderiaScript.ScorePoints);
        }
        
    }
}
