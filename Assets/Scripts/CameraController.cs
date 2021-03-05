using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    public float xSpeed;
    public float ySpeed;

    private Vector2 moveTo;
    private Rigidbody2D rb2d;
    // Use this for initialization
    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveTo = PlayerController.playerPos;
        float dist = Mathf.Sqrt(System.Math.Abs(transform.position.x - PlayerController.playerPos.x) + System.Math.Abs(transform.position.y - PlayerController.playerPos.y)); // Calculate Distance to player
        rb2d.velocity = new Vector2((moveTo.x - transform.position.x) * xSpeed, (moveTo.y - transform.position.y) * ySpeed); // Make Camera move towards the player
    }
}