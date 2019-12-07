using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {
    Rigidbody2D rb2d;
    public float speed = 5f;
    public int overflow = 29;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        float direction = Input.GetAxisRaw("Horizontal");
        rb2d.velocity = new Vector2(direction * speed, rb2d.velocity.y);

        if (direction != 0)
        {
            transform.localScale = new Vector3(direction, 1, 1);
        }

        if (gameObject.transform.position.x >= overflow)
        {
            transform.position = new Vector2(-overflow + .15f, transform.position.y);
        }

        if (gameObject.transform.position.x <= -overflow)
        {
            transform.position = new Vector2(overflow - .15f, transform.position.y);
        }
	}
}
