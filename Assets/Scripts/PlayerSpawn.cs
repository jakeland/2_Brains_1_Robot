using UnityEngine;
using System.Collections;

public class PlayerSpawn : MonoBehaviour {
	private GameObject playercheck;
	public GameObject player;
	void Start (){

		}
	void Update() {
		playercheck = GameObject.FindGameObjectWithTag ("Player");
		if (playercheck == null) {
			Instantiate(player, transform.position, transform.rotation);
				}
		}
}
