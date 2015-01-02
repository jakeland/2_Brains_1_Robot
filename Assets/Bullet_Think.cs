using UnityEngine;
using System.Collections;

public class Bullet_Think : MonoBehaviour {

	// Use this for initialization

	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag == "Player")
						col.gameObject.SendMessage ("bigHurt");
		if (col.tag != "Bullet")
		Destroy (transform.gameObject);

	
	}
}
