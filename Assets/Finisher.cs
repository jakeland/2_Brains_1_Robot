using UnityEngine;
using System.Collections;

public class Finisher : MonoBehaviour {
	public float health = 100f;
	private GameObject God;
	float hurtTimer = 0.5f; 
	public float maxhurtTimer = 2f;
	public float damage = 10f;
	public GameObject OpenFence;
	private bool done = false;

	// Use this for initialization
	void hurt () {
		if(hurtTimer <= 0){
		health -= damage;
		hurtTimer = maxhurtTimer;
		}

	}
	void Start(){
		God = GameObject.FindGameObjectWithTag ("God");


		OpenFence.renderer.material.color = new Color(1f,1f,1f,0f);



		}
	
	// Update is called once per frame
	void Update () {
		if(hurtTimer > 0)
		hurtTimer -= Time.deltaTime;
		if(done == false)
		if(health <= 0)
		{
			killFence();
			done = true;

		}


	}

	void killFence(){
		OpenFence.renderer.material.color = new Color(1f,1f,1f,1f);
		God.SendMessage ("RobotFree");

	}




}
