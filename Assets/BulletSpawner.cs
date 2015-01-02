using UnityEngine;
using System.Collections;

public class BulletSpawner : MonoBehaviour {
	public Rigidbody2D bullet;
	public float bulletspeed = 2.0f;
	

	void Fire(){
		Rigidbody2D clone;
		clone = Instantiate (bullet, transform.position, transform.rotation) as Rigidbody2D;
		clone.velocity = transform.TransformDirection (Vector3.up * bulletspeed * -1);

	}
}
