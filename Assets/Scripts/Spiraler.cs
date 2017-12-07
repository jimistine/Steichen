using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spiraler : MonoBehaviour {

	public float circleSpeed = 1;
	public float forwardSpeed = -1; // Assuming negative Z is towards the camera
	public float circleSize = 1;
	public float moveSpeed = 0.1f;
 
	public float xPos;
	public float yPos; 
	public float zPos;	
	// Use this for initialization
	void Start ()
	{
		xPos = gameObject.transform.position.x;
		yPos = gameObject.transform.position.y;
		zPos = gameObject.transform.position.z;

	}
	
	// Update is called once per frame
	void Update ()
	{
		
		xPos = Mathf.Sin(Time.time * circleSpeed) * circleSize;
		zPos = Mathf.Cos(Time.time * circleSpeed) * circleSize;
//		zPos += forwardSpeed * Time.deltaTime;
		
		circleSize += moveSpeed;
		
		gameObject.transform.position = new Vector3(xPos, 0,zPos); 
	}
}
