using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] GameObject goCreate;

    [SerializeField] float fTimeIntervals;

    [SerializeField] Vector3 v3SpawnPsJitter;

    float fTimer = 0;

    void Start()
    {
        fTimer = fTimeIntervals;    

    }

    
    void Update()
    {

        fTimer -= Time.deltaTime;
        if(fTimer <= 0)
        {

            fTimer = fTimeIntervals;
            Vector3 v3SpawnPos = transform.position;
            v3SpawnPos += Vector3.right * v3SpawnPsJitter.x * (Random.value - 0.5f);
            v3SpawnPos += Vector3.forward * v3SpawnPsJitter.x * (Random.value - 0.5f);
            v3SpawnPos += Vector3.up * v3SpawnPsJitter.x * (Random.value - 0.5f);
            //print(v3SpawnPos);
            Instantiate(goCreate, v3SpawnPos,Quaternion.identity);


        }

        
    }
}
