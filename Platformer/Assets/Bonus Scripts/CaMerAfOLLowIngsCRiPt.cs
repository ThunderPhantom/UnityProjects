using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaMerAfOLLowIngsCRiPt : MonoBehaviour {
	public Transform transformplayersthe;
	// Use this for initialization
	void Start () {
		transformplayersthe = GameObject.FindGameObjectWithTag ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector2 (transformplayersthe.position.x, transform.position.y);
	}
}
