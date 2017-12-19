using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Valve.VR.InteractionSystem;

public class Spiraler : MonoBehaviour {

    private SteamVR_TrackedController _controller;


    public float circleSpeed;
	public float forwardSpeed;
	public float circleSize;
	public float circleChangeSpeed;
 
	public float xPos;
	public float yPos; 
	public float zPos;

    public bool spiral = true;


    void Start()
    {
        xPos = gameObject.transform.position.x;
        zPos = gameObject.transform.position.z;
    }

    void Update()
    {
        if (GM.Player.Stop)
        {
            xPos = Mathf.Sin(Time.time * circleSpeed) * circleSize;
            zPos = Mathf.Cos(Time.time * circleSpeed) * circleSize;

            gameObject.transform.position = new Vector3(xPos, yPos, zPos);
            circleSize += circleChangeSpeed;

            if (circleSize < -50)
            {
                circleSize -= circleChangeSpeed;
            }
        }
    }	
}

