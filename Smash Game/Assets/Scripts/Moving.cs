using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {
    public float speed;
    Rigidbody rb;
	
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	
	void Update () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        if (moveHorizontal == 1)
        {
            transform.localScale = new Vector3(1, 1, 1);
        } else if (moveHorizontal == -1)
        {
            transform.localScale = new Vector3(1, -1, 1);
            transform.localScale = new Vector3(1, -1, 1);
        }

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal")*speed, rb.velocity.y, 0.0f);
        rb.velocity = movement;
	}
}
