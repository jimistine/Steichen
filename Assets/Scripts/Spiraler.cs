using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Spiraler : MonoBehaviour {

	public float circleSpeed;
	public float forwardSpeed;
	public float circleSize;
	public float circleChangeSpeed;
 
	public float xPos;
	public float yPos; 
	public float zPos;	
	
	public bool spiral_out;
	public  bool spiral_in = true;
    // Use this for initialization
    void Start()
    {
        xPos = gameObject.transform.position.x;
        //		yPos = gameObject.transform.position.y;
        zPos = gameObject.transform.position.z;
    }
    // Update is called once per frame
    void Update()
    {

        xPos = Mathf.Sin(Time.time * circleSpeed) * circleSize;
        zPos = Mathf.Cos(Time.time * circleSpeed) * circleSize;
        //		zPos += forwardSpeed * Time.deltaTime;

        gameObject.transform.position = new Vector3(xPos, yPos, zPos);
        circleSize += circleChangeSpeed;

        if (circleSize < -50)
        {
            circleSize -= circleChangeSpeed;
        }
    }	
}

