using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    // Defined once and is not updated
    //[SerializeField]float xValue = 0;
    [SerializeField] float yValue= 0;
    [SerializeField]float moveSpeed=1f;
    //[SerializeField] float zValue=0;

    // Start is called before the first frame update
    void Start()
    {

        PrintInstructions();
    // transform.Translate(1,0,0);   
    // move object by adding (1,0,0) to the existing position
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    
    }

    void PrintInstructions()
    {
        //Debug.Log prints into the console
       Debug.Log("Welcome to the game");
       Debug.Log("Move the player with arrow keys or WSD");
       Debug.Log("Don't hit the walls!"); 
    }

    void MovePlayer()
    {
        //Time.deltaTime tells how long each frame takes to execute(depends on the computer)
        //multiplying by it makes the movement frame rate independent


        float xValue=Input.GetAxis("Horizontal")*Time.deltaTime*moveSpeed; 
        float zValue=Input.GetAxis("Vertical")*Time.deltaTime*moveSpeed;

        transform.Translate(xValue,yValue,zValue); 
    }





}
