using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCamera: MonoBehaviour {
	public Transform transformplayersthe;
	// Use this for initialization
	void Start () {
		transformplayersthe = GameObject.FindGameObjectWithTag ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (transformplayersthe.position.x, transform.position.y, -10);
		if (transformplayersthe.GetComponent<Moving> ().groundchecky && (transformplayersthe.position.y >  transform.position.y+2 || transformplayersthe.position.y <  transform.position.y-2)) {
			transform.position = new Vector3 (transformplayersthe.position.x, transformplayersthe.position.y, -10);
		}
	}
}
