using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    GameObject Doodle;
	// Use this for initialization
	void Start () {
        Doodle = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (Doodle.transform.position.y > gameObject.transform.position.y)
        {
            transform.position = new Vector3(0, Doodle.transform.position.y, -10);
        }
	}
}
