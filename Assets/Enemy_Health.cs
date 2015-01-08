using UnityEngine;
using System.Collections;

public class Enemy_Health : MonoBehaviour {

	public float maxHealth = 30f;
	public float health;
	public float maxHurtTimer = 1.2f;
	public float damage = 10f;
	public float hurtTimer;
	private float maxHealthBar;
	public Transform healthbar;
	void Awake(){
		hurtTimer = maxHurtTimer;
		maxHealthBar = healthbar.localScale.x;
		health = maxHealth;
		}

	void hurt (){
		if (health > 0 && hurtTimer < 0)
						health -= damage;
		hurtTimer = 1.2f;

		
	}

	void Update (){
		if (health <= 0) {
						health = 0;
			Destroy(transform.gameObject);
				}
		float currHealthBar = (health / maxHealth) * maxHealthBar;

		healthbar.transform.localScale = new Vector3(currHealthBar,1,1);



		if (hurtTimer > 0)
						hurtTimer -= Time.deltaTime;
		 
	}
	
}
