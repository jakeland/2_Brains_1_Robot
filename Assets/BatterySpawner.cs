using UnityEngine;
using System.Collections;

public class BatterySpawner : MonoBehaviour {

	// Use this for initialization
	public Transform battery;
	// Use this for initialization
	void Spawn(){
		Instantiate (battery, new Vector3 (transform.position.x, transform.position.y,transform.position.z) ,Quaternion.identity);
		
		
	}
}
