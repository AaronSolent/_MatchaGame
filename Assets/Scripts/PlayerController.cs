using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	internal Rigidbody2D rb2d;
	internal Animator anim;
	public float speed;
	public static Vector3 playerPos;
	internal bool facingRight = true;
    // Start is called before the first frame update
    void Start()
	{
		rb2d = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
	{	
		playerPos = transform.position;
	    float moveX = Input.GetAxisRaw("Horizontal");
		float moveY = Input.GetAxisRaw("Vertical"); 
		anim.SetFloat("DirX",moveX);
		anim.SetFloat("DirY",moveY);
		
		
		rb2d.velocity = new Vector2(moveX * speed,moveY * speed);
		
	}
	public void Flip()
	{
		facingRight = !facingRight;
		Vector3 newScale = transform.localScale;
		newScale.x *= -1;
		transform.localScale = newScale;
	}
}
