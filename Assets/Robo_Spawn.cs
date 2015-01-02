using UnityEngine;
using System.Collections;

public class Robo_Spawn : MonoBehaviour {
	public Transform NPC;
	// Use this for initialization
	void Spawn(){
		Instantiate (NPC, new Vector3 (transform.position.x, transform.position.y,transform.position.z) ,Quaternion.identity);


		}
}
