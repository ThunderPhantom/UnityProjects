using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    private GameObject player; //holds the player gameobject
    public Vector3 offset = new Vector3(0, 0, -10); //Gives the camera a zoom out so u can actually see
    private Vector3 velocity = Vector3.zero; //holds the velocity of the player and sets it to 0

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player"); //assigns the player variable to a gameobject with the player tag
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.position = Vector3.SmoothDamp(transform.position, player.transform.position + offset, ref velocity, .3f); 
        //camera smoothly follows the player using the velocity and the player position
	}
}
