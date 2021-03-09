using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerControll : MonoBehaviour
{
    [SerializeField] Vector3 v3Force;

    [SerializeField] KeyCode keyPosizitve;
    [SerializeField] KeyCode keyNegative;

    void FixedUpdate()
    {

        if (Input.GetKey(keyPosizitve))
        {
            GetComponent<Rigidbody>().velocity += v3Force;
        }
        if (Input.GetKey(keyNegative))
        {
            GetComponent<Rigidbody>().velocity -= v3Force;
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "coin")
        {
            //CoinsAmount++;
            Destroy(other.gameObject);
            //other.gameObject.SetActive(false);
        }
    }
    
}

