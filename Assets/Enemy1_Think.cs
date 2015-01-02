using UnityEngine;
using System.Collections;

public class Enemy1_Think : MonoBehaviour {
	public float fireTime = 3;
	private float timer = 0;

	// Use this for initialization

	public GameObject barrel;
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		if (timer < fireTime)
			timer += Time.deltaTime;
		if (timer > fireTime) {
						fire ();
						timer = 0;
				}				
	}

	void fire(){

		barrel.SendMessage ("Fire");

	}
}
