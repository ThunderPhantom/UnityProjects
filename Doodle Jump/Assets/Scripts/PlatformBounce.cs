using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBounce : MonoBehaviour {
    Rigidbody2D rb2d;
    public float jumpForce = 10f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb2d = collision.collider.GetComponent<Rigidbody2D>();
            Vector2 velocity = rb2d.velocity;
            velocity.y = jumpForce;
            rb2d.velocity = velocity;
        }
        
    }
}
