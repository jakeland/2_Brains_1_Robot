using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	[HideInInspector]
	public float playerRotation;
	
	
	
	public float moveForce = 365f;
	public float maxSpeed = 5f;
	
	
	
	
	private Animator anim;
	
	
	void Awake ()
	{
		
	}
	
	void Update ()
	{
		float arml = Input.GetAxis ("Fire3");
		if (arml == 1)
		{

		}
	}
	
	void FixedUpdate ()
	{

		float h = Input.GetAxis ("Horizontal");
		float j = Input.GetAxis ("Vertical");
		//anim.SetFloat("Speed", Mathf.Abs(h));


		if (h > -1 && h < 1) {
						rigidbody2D.velocity = new Vector2 (0.0f, rigidbody2D.velocity.y);

				}
		if (j > -1 && j < 1){
						rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, 0.0f);

		}
		if (h * rigidbody2D.velocity.x < maxSpeed)
			
			rigidbody2D.AddForce (Vector2.right * h * moveForce);
		
		if (Mathf.Abs (rigidbody2D.velocity.x) > maxSpeed)
			
			rigidbody2D.velocity = new Vector2 (Mathf.Sign (rigidbody2D.velocity.x) * maxSpeed, rigidbody2D.velocity.y);
		
		if (j * rigidbody2D.velocity.y < maxSpeed)
			rigidbody2D.AddForce (Vector2.up * j * moveForce);
		
		if (Mathf.Abs (rigidbody2D.velocity.y) > maxSpeed)
			rigidbody2D.velocity = new Vector2 ( rigidbody2D.velocity.x, Mathf.Sign (rigidbody2D.velocity.y) * maxSpeed);

	}

	
	
	
	
}