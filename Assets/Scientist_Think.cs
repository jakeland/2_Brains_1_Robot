using UnityEngine;
using System.Collections;

public class Scientist_Think : MonoBehaviour {
	public float timer;
	public float maxTimer = 1.7f;
	public float health;
	public float maxHealth = 20f;
	public float damage = 10f;
	// Use this for initialization
	void Start () {
		timer = maxTimer;
		health = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		if (timer > 0) {
						timer -= Time.deltaTime;
						
				}
	
	}

	void hurt () {
		if (timer <= 0){
			health -= damage;

		}
}

}
