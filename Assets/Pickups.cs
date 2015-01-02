using UnityEngine;
using System.Collections;

public class Pickups : MonoBehaviour {
	public float regen = 5f;
	public float ePickUp = 25f;
	public float hPickUp = 25f;
	public float maxHealth = 100f;
	public float maxEnergy = 300f;
	public float energyDet = -1.2f; //rate of energy deterioration.
	public float hurtTimer = 3;
	private bool canDamage = true;
	private float energy;
	private float health;
	public GameObject timerbar;
	public GameObject healthbar;

	

	// Use this for initialization
	private GameObject it;


	void Awake (){
		energy = maxEnergy;
		health = maxHealth;
	}

	void Update(){
		if(health > maxHealth)
			health = maxHealth;
		if(energy > maxEnergy)
			energy = maxEnergy;
		
		energy += Time.deltaTime * energyDet;

		healthbar.transform.localScale = new Vector3 ( (health/maxHealth), 1,1);
		timerbar.transform.localScale = new Vector3 ((energy/maxEnergy),1,1);

		if (health <= 0)
		{
			Application.LoadLevel(Application.loadedLevel);
		}


}



	void hurt(){
		health --;

		healthbar.transform.localScale =new Vector3 ((health/maxHealth),1,1);

	}
	void bigHurt(){
		if(canDamage == true)
		{
		health -= 10;
		canDamage = false;
		countdown();
		}
	}

		void countdown(){
		while (hurtTimer > 0)
		{
			hurtTimer -= Time.deltaTime;

		}
		canDamage = true;
		hurtTimer = 3;
	}



	void OnTriggerEnter2D (Collider2D col)
	{
		if(col.gameObject.tag == "Wrench" && health < maxHealth)
		{

			health += hPickUp;
			if(health > maxHealth)
			{
				health = maxHealth;
			}

			col.SendMessage("Kill");
		}

		if(col.gameObject.tag == "Battery" && energy < maxEnergy)
		{
			
			energy += ePickUp;
			if(energy > maxEnergy)
			{
				energy = maxEnergy;
			}
			timerbar.transform.localScale = new Vector3 ( (energy/maxEnergy), 1,1);
			col.SendMessage("Kill");
		}
	}
	void pickup(string passedT){
		if(passedT == "Player_Spawn"){
			if(health <= maxHealth)
			{
				health+=regen * Time.deltaTime;
				healthbar.transform.localScale = new Vector3 ((health/maxHealth), 1, 1);

			}

		}


	}
}
