using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectaColicion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Debug.Log("chocando");
        Destroy(other.gameObject);
        Debug.Log("chocando2");
    }
}
