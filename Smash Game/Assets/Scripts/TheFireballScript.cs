using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheFireballScript : MonoBehaviour {
    private float startPos;
    public float endPos = 5;
	// Use this for initialization
	void Start () {
        startPos = transform.position.x;
        GetComponent<Rigidbody>().velocity = Vector3.right * 15;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x - startPos >= endPos)
        {
            Destroy(gameObject);
        }
	}
}
