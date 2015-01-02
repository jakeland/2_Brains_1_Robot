using UnityEngine;
using System.Collections;

public class Finisher : MonoBehaviour {
	float health = 100;
	private GameObject God;
	float hurtTimer = 2; 
	public float maxhurtTimer = 2;
	public float damage = 10;
	// Use this for initialization
	void hurt () {
		if(hurtTimer <=0){
		health -= damage;
		hurtTimer = maxhurtTimer;
		}

	}
	void Start(){
		God = GameObject.FindGameObjectWithTag ("God");


		}
	
	// Update is called once per frame
	void Update () {
		if(hurtTimer >0)
		hurtTimer -= Time.deltaTime;

		if(health < 0)
		{
			destroyFence();
			God.SendMessage("Complete");
		}

	}

	void destroyFence(){

	}




}
