using UnityEngine;
using System.Collections;

public class Spawn_Thing : MonoBehaviour {
	public Transform Spawnee;

	void Spawn(){
		Instantiate (Spawnee, transform.position , transform.rotation);
		
		
	}
}