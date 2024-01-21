using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droper : MonoBehaviour
{

    MeshRenderer renderer;
    Rigidbody body;
    // Start is called before the first frame update

    [SerializeField] float WaitingTime=5f;
    void Start()
    {
        renderer=GetComponent<MeshRenderer>();
        renderer.enabled=false;

        body=GetComponent<Rigidbody>();
        body.useGravity=false;

    }

    // Update is called once per frame
    void Update()
    {

    if(Time.time > WaitingTime) 
    {
        renderer.enabled=true;
        body.useGravity=true;
        
 
    }       

    }
}



//    GetComponent<MeshRenderer>().material.color=Color.red;
