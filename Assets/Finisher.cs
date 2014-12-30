using UnityEngine;
using System.Collections;

public class Finisher : MonoBehaviour {
	float health = 100;
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
	
	// Update is called once per frame
	void Update () {
		if(hurtTimer >0)
		hurtTimer -= Time.deltaTime;

		if(health < 0)
		{
			destroyFence();
		}

	}

	void destroyFence(){
		//show fence, free robot;
	}




}
