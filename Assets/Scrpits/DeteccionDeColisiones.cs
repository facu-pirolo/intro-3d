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
        Debug.Log("Contacto con: " + col.gameObject.name);
        if (col.gameObject.name == "Player")
        {
            Destroy(gameObject);
            scoreManager.AddScore(mercaderiaScript.ScorePoints);
        }
        
    }
}
