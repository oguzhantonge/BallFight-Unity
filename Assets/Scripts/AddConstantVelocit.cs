using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddConstantVelocit : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Force;

    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity += v3Force;

    }
}
