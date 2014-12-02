using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
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

	}
	
	void FixedUpdate ()
	{
		
				float h = Input.GetAxis ("Horizontal");
				float j = Input.GetAxis ("Vertical");
				//anim.SetFloat("Speed", Mathf.Abs(h));
		
				if (h * rigidbody2D.velocity.x < maxSpeed)
			
						rigidbody2D.AddForce (Vector2.right * h * moveForce);
		
				if (Mathf.Abs (rigidbody2D.velocity.x) > maxSpeed)
			
						rigidbody2D.velocity = new Vector2 (Mathf.Sign (rigidbody2D.velocity.x) * maxSpeed, rigidbody2D.velocity.y);
		
				if (j * rigidbody2D.velocity.y < maxSpeed)
						rigidbody2D.AddForce (Vector2.right * j * moveForce);
				
				if (Mathf.Abs (rigidbody2D.velocity.y) > maxSpeed)
						rigidbody2D.velocity = new Vector2 (Mathf.Sign (rigidbody2D.velocity.y) * maxSpeed, rigidbody2D.velocity.y);

	}
		
		
	
	
}