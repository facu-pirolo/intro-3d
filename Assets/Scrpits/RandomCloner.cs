using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCloner : MonoBehaviour
{
    public int randomNumber;
    public int min;
    public int max;
    public GameObject Prefab1;
    public GameObject Prefab2;
    public GameObject Prefab3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void CloneRandom()
    {
        randomNumber = Random.Range(min, max + 1);
        GameObject clone = Prefab2;
        if (randomNumber == 0)
        {
            clone = Prefab1;
        }
        else if(randomNumber == 1)
        {
            clone = Prefab2;
        }
        else if (randomNumber == 2)
        {
            clone = Prefab3;
        }
        Instantiate(clone);
    }
}
