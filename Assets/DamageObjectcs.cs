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
        Debug.Log("Contacto");
        if (col.gameObject.name == "Player")
        {
            Destroy(gameObject);
            healthManager.TakeDamage(damagePoints);
        }

    }
}

