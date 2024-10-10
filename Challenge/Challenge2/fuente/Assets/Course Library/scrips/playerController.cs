using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour 
{
    public GameObject silla;

    void Start()
    {
    }

    void Update()
    {
        float hor = Input.GetAxis("Horizontal");

        if (transform.position.x > 23)
        {
            transform.position = new Vector3(23, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -23)
        {
            transform.position = new Vector3(-23, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(silla, transform.position, silla.transform.rotation);
        }

        transform.Translate(Vector3.right * Time.deltaTime * 10 * hor);
    }
}