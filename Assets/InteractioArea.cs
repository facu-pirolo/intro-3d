using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractioArea : MonoBehaviour
{
    public GameObject UIInteraxtionMessage;
    public bool canInteract;
    public MercaderiaScripts mercaderia;

    private void Start()
    {
        UIInteraxtionMessage.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (canInteract)
            {
                Destroy(mercaderia.gameObject);
                EndInteraction();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
         mercaderia = other.GetComponent<MercaderiaScripts>();
        if (mercaderia)
        {
            UIInteraxtionMessage.SetActive(true);
            canInteract = true;
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        UIInteraxtionMessage.SetActive(false);
        mercaderia = null;
        canInteract = false;
    }

    void EndInteraction()
    {
        UIInteraxtionMessage.SetActive(false);
        mercaderia = null;
        canInteract = false;
    }
  
    
}
