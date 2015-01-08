using UnityEngine;
using System.Collections;

public class Enemy1_Think : MonoBehaviour {
	public float fireTime = 2.5f;
	public float timer = 0f;
	private Transform player; // sets the player as the target
	int layerMask = 1 << 10; // the layermask an enemy is on
	public Transform barrel; // barrel of the gun, spawns bullet
	private GameObject target; // finds the player, what the enemy is aiming at
	private Quaternion targetRot; //angle at which the enemy is rotating towards
	public float rotationSpeed = 5; //speed at which enemy is rotating
	public float targetDist = 7; //distance from enemy to target


	void Awake () {
		layerMask = ~layerMask;
		}

	void Start () {
		target = GameObject.FindGameObjectWithTag ("Player");
		player = target.transform;
		}

	public enum FacingDirection {
		UP = 270,
		DOWN = 90,
		LEFT = 180,
		RIGHT = 0
	}
	// Update is called once per frame
	Quaternion FaceObject(Vector2 startingPosition, Vector2 tagetPosition, FacingDirection facing){
		Vector2 direction = tagetPosition - startingPosition;
		float angle = Mathf.Atan2 (direction.y, direction.x) * Mathf.Rad2Deg;
		angle -= (float)facing;
		return Quaternion.AngleAxis (angle, Vector3.forward);
		}

	void Update () {
		if (timer < fireTime)
			timer += Time.deltaTime;
		if (Vector3.Distance (player.position, transform.position) <= targetDist) {
						
			targetRot = FaceObject (transform.position,player.position,FacingDirection.UP);
			transform.rotation = Quaternion.Slerp (transform.rotation,targetRot,Time.deltaTime * rotationSpeed);
				

		Ray2D ray = new Ray2D (transform.position, -transform.up);
		RaycastHit2D find =  Physics2D.Raycast(transform.position,ray.direction, targetDist, layerMask);

		if (find.collider != null) {						
						if (find.transform.gameObject.tag == "Player") {
								
								if (timer >= fireTime) {



										fire ();
										timer = 0;
								}	
						}
			}
				}
		else {
						transform.rotation = Quaternion.Slerp (transform.rotation, targetRot, Time.deltaTime * rotationSpeed);
				}

	}

	void fire(){

		barrel.BroadcastMessage ("Fire");

	}
}
