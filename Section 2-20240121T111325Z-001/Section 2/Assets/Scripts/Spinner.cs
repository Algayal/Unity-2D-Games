using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float xVal;
    [SerializeField] float yVal;
    [SerializeField] float zVal;



    // Update is called once per frame
    void Update()
    {

      transform.Rotate(xVal,yVal,zVal);  
    }
}
