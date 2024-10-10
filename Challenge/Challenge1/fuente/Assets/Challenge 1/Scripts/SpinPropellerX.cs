using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float propellerSpeed = 1000f;

    // Update is called once per frame
    void Update()
    {
        // Rotate the propeller around its Z axis
        transform.Rotate(Vector3.forward * propellerSpeed * Time.deltaTime);
    }
}
