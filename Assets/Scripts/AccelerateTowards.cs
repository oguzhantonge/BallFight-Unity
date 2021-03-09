using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerateTowards : MonoBehaviour
{
    [SerializeField] Transform transTowards;

    [SerializeField] float speed = 8;

    Rigidbody rigid;
 
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        if(transTowards == null)
        {
            transTowards = FindObjectOfType<AddPlayerControll>().transform;

        }

    }
    void Update()
    {
        rigid.velocity += (transTowards.position - transform.position).normalized * speed * Time.deltaTime;

    }
}
