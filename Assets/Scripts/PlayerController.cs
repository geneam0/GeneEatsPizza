using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float speed=.1f;
	public float jump=.1f;
	private float moveVelocity;
	private bool grounded = true;

	private Rigidbody2D rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			rb.velocity = new Vector2(0f, jump);
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			rb.velocity = new Vector2(speed, 0f);
		}
        if (Input.GetKeyDown (KeyCode.DownArrow)) {
			rb.velocity = new Vector2(0f, -jump);
		}
		transform.rotation = Quaternion.Euler(0, 0, 0);
	}
}
