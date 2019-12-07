using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEnemyAI : MonoBehaviour {
    public int dirmod = 1;
    public Vector2 max;
    public Vector2 min;
    public Rigidbody2D rb2d;
    public int speed;
    public int a = 5;
	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        min = new Vector2(transform.position.x - a, transform.position.y);
        max = new Vector2(transform.position.x + a, transform.position.y);

	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x < min.x && dirmod < 0)
        {
            dirmod = 1;
        }
        if (transform.position.x > max.x && dirmod > 0)
        {
            dirmod = -1;
        }
        rb2d.velocity = new Vector2(dirmod * speed, 0);
    }
}
