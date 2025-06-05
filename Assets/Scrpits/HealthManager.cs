using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int health;
    public int maxHealthPuntos;
    public UiManager uiManager;
    // Start is called before the first frame update
    void Start()
    {
        uiManager = FindObjectOfType<UiManager>();
        maxHealthPuntos = 100;
        health = maxHealthPuntos;
    }

 
    public void TakeDamage(int damagePoints)
    {
        if (health <= damagePoints)
        {
            //gameover
            return;
        }
        health -= damagePoints;
        uiManager.UpdateHealth(health);
    }
}
