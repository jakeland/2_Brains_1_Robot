using UnityEngine;
using System.Collections;

public class NPC_Thought : MonoBehaviour {
	public float NPCSpeed = 2.0f;
	public float timer = 0f;
	private bool startTimer = false;
	public float maxTimer = 4f;
	private GameObject god;

	// Use this for initialization
	void Start(){
		god = GameObject.FindGameObjectWithTag ("God");
		}

	void Leave() {
		rigidbody2D.velocity = Vector3.up * NPCSpeed;
		startTimer = true;
		}

	void Update() {
		if (startTimer == true) {
						timer += Time.deltaTime;
						
				}

		if (timer >= maxTimer) {

			Destroy(transform.gameObject);
			god.SendMessage("Complete");
		}
					

		}
}
