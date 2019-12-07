using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Lives : MonoBehaviour {
    public float deathPosition = -25f; //holds the y position that kills the player
    public Vector2 respawnPoint; //holds the player spawnpoint
    public int lives = 3; //defines the number of lives
    public float timeStamp; 
    public bool invincibility = false;
    public float invTime = 3f;
    public Rigidbody2D rb2d;


	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        respawnPoint = transform.position;
    }
	
    void respawn()
    {
        transform.position = respawnPoint;
        GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        
    }

    void damage()
    {
        if (!invincibility)
        {
            rb2d.velocity = new Vector3(.5f - rb2d.velocity.normalized.x, .5f) * 10;
            lives--;
            GameObject.Find("LivesText").GetComponent<Text>().text = "Lives: " + lives;
            invincibility = true;
            timeStamp = Time.time + invTime;
            
            GetComponent<Moving>().movingOn = false;
        }
        if (lives < 1)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Checkpoint")
        {
            respawnPoint = collision.transform.position;
        } 
        else if (collision.tag == "Damage")
        {
            damage();
            //lanches you further going left to right than right to left

            
        }
    }
    // Update is called once per frame
    void Update () {
        if (timeStamp <= Time.time)
        {
            invincibility = false;
        }
        if (transform.position.y < deathPosition)
        {
            respawn();
        }
	}
}
