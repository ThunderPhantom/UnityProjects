using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {
    public float speed; //holds the speed value in float
    private Rigidbody2D rb2d; //assigns rb2d to the rigidbody
    public float jumpPower; //defines how powerful ur jump is
    Animator anim; //assigns animator component to anim
    public bool movingOn = true; //sets movingon boolean to true
    public float jumpHeight = 5;
    [Range(0.1f, 2)]
    public float jumpTime = 0.5f;
    private float jumpForce;
    private float gravity;
	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>(); //assigns rb2d to the rigidbody component
        anim = GetComponent<Animator>(); //assigns anim to animator component
    }

    // Update is called once per frame
    void Update()
    {
        jumpForce = 2 * jumpHeight / jumpTime;
        gravity = 2 * jumpHeight / (jumpTime * jumpTime);
        rb2d.gravityScale = gravity;
        float moveHorizontal = Input.GetAxisRaw("Horizontal"); //stores the direction ur going in the horizontal axis as -1, 0, or 1
        float moveVertical = Input.GetAxis("Vertical"); //stroes the direction ur going on the vertical axis as -1, 0, or 1
        Vector2 movement = new Vector2(moveHorizontal * speed, rb2d.velocity.y); //multiplies the movehorizontal direction by the speed u are traveling at;
        if (movingOn) //if movingon boolean is true, ur velocity is set to the speed and direction u want to go
        {
            
            rb2d.velocity = (movement); //sets the player velocity to the movement vector 2
        }

        if (rb2d.velocity.y == 0) //checks if the y velocity is 0
        {
            if (Input.GetKey(KeyCode.UpArrow)) //checks if up arrow key is pressed
            {

                movement.y = jumpForce; //you jump, ur height is based on the jomp power value

            }
            rb2d.velocity = movement;
            movingOn = true; //movingon bool is set to true
        }

        anim.SetBool("Walking", moveHorizontal != 0); // if you are moving horizontal, the condition walking for the animator is set to true    {
        anim.SetBool("inAir", rb2d.velocity.y != 0);


        if (moveHorizontal == -1) //check if you are moving left
        {
            GetComponent<SpriteRenderer>().flipX = true; //flips ur character sprite renderer around
        }
        else //or else
        {
            GetComponent<SpriteRenderer>().flipX = false; //it doesn't flip ur character sprite renderer around
        }
            

    }
}
