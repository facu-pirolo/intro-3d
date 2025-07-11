using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageObjectcs : MonoBehaviour
{
    public HealthManager healthManager;
    public int damagePoints;

    public void Start()
    {
        healthManager = FindObjectOfType<HealthManager>();
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "SimpleFPSController")
        {
            Destroy(gameObject);
            healthManager.TakeDamage(damagePoints);
        }

    }
}

