using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	[HideInInspector]
	public float playerRotation;
	private string rotate = "";
	
	
	public float moveForce = 365f;
	public float maxSpeed = 5f;
	public float rotationRate = 5f;

	
	
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
		if (Input.GetButton ("Left") && Input.GetButton ("Right")) {
			h = 0;
						
						
				} 
		if (Input.GetButton ("Up") && Input.GetButton ("Down")) {
						j = 0;
				}
						if (h ==-1f && j == 0) {
								rotate = "w";
						}
						if (h == 1f && j == 0) {
								rotate = "e";
						}
						if (h == 0 && j == 1f) {
								rotate = "n";
						}
						if (h == 0 && j == -1f) {
								rotate = "s";
						}
						if (h == 1f && j ==1f) {
								rotate = "ne";
						}
						if (h == 1f && j == -1f) {
								rotate = "se";
						}
						if (h == -1f && j == 1f) {
								rotate = "nw";
						}
						if (h == -1 && j == -1f) {
								rotate = "sw";
						}

						if (h > -1 && h < 1) {
								rigidbody2D.velocity = new Vector2 (0.0f, rigidbody2D.velocity.y);
								
						}
						if (j > -1 && j < 1) {
								rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, 0.0f);
								
						}
						if (h * rigidbody2D.velocity.x < maxSpeed)
			
								rigidbody2D.AddForce (Vector2.right * h * moveForce);
		
						if (Mathf.Abs (rigidbody2D.velocity.x) > maxSpeed)
			
								rigidbody2D.velocity = new Vector2 (Mathf.Sign (rigidbody2D.velocity.x) * maxSpeed, rigidbody2D.velocity.y);
		
						if (j * rigidbody2D.velocity.y < maxSpeed)
								rigidbody2D.AddForce (Vector2.up * j * moveForce);
		
						if (Mathf.Abs (rigidbody2D.velocity.y) > maxSpeed)
								rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, Mathf.Sign (rigidbody2D.velocity.y) * maxSpeed);
						
								checkRotate ();
				
	}

	void checkRotate(){
		float currZ = transform.rotation.eulerAngles.z;
		float targetZ;
		Quaternion toRot;
		if (currZ < 0)
						currZ = 360 + currZ;
	switch (rotate) {
	
		case "n":
			targetZ = 0f;
			toRot = Quaternion.Euler(0f,0f,targetZ);
			break;
		case "s":
			targetZ = 180f;
			toRot = Quaternion.Euler(0f,0f,targetZ);
			break;
		case "e":
			targetZ = 270f;
			toRot = Quaternion.Euler(0f,0f,targetZ);
			break;
		case "w":
			targetZ = 90f;
			toRot = Quaternion.Euler(0f,0f,targetZ);
			break;
		case "ne":
			targetZ = 315f;
			toRot = Quaternion.Euler(0f,0f,targetZ);

			break;
		case "se":
			targetZ = 225;
			toRot = Quaternion.Euler(0f,0f,targetZ);
			break;
		case "sw":
			targetZ = 135;
			toRot = Quaternion.Euler(0f,0f,targetZ);
			break;
		case "nw":
			targetZ = 45;
			toRot = Quaternion.Euler(0f,0f,targetZ);
			break;
		default:
			targetZ = transform.eulerAngles.z;
			toRot = Quaternion.Euler(0f,0f,targetZ);
			break;
				}
		transform.rotation = Quaternion.Slerp (transform.rotation, toRot, Time.deltaTime * rotationRate);
	}
	
}