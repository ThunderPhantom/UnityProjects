using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerCollision : MonoBehaviour {


	private BoxCollider2D Box;
	private GameObject Player;
	// Use this for initialization
	void Start () {
		
		Box = GetComponent<BoxCollider2D> ();
		Player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Box.IsTouching (Player.GetComponent<BoxCollider2D> ())) {

			gameObject.SetActive (false);
		}
	}
}
