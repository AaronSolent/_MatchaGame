using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerController : PlayerController
{
	public float jumpHeight = 0f;
	public bool grounded = false;
	
	// Update is called every frame, if the MonoBehaviour is enabled.
	protected void Update()
	{
		playerPos = transform.position;
		float moveX = Input.GetAxisRaw("Horizontal");
		anim.SetFloat("DirX",moveX);
		rb2d.velocity = new Vector2(moveX * speed, rb2d.velocity.y);
		if(Input.GetButtonDown("Jump") && grounded)
		{
			rb2d.velocity = new Vector2(rb2d.velocity.x, jumpHeight);
		}
		if(rb2d.velocity.x > 0.1f && !facingRight)
		{
			Flip();
		}
		if(rb2d.velocity.x < -0.1f && facingRight)
		{
			Flip();
		}
		
	}
	
	// OnTriggerEnter is called when the Collider other enters the trigger.
	protected void OnTriggerEnter2D(Collider2D other)
	{
		if(other.CompareTag("Floor"))
		{
			grounded = true;
		}
	}
	protected void OnTriggerExit2D(Collider2D other)
	{
		if(other.CompareTag("Floor"))
		{
			grounded = false;
		}
	}

}
