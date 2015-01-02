using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	
	private string passT = "";
	private bool canKill = false;
	public float dt = 0.2f;

	void Awake(){

		passT = gameObject.tag;


	}
	void Update(){
		if(canKill)
		{
				dt -= Time.deltaTime;
				Kill();
		}

	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player")
		{
		col.gameObject.SendMessage("pickup",passT);
		}
	}
	// Use this for initialization
	void OnTriggerStay2D(Collider2D col)
	{

		if (col.gameObject.tag == "Player") 
		{

			col.gameObject.SendMessage("pickup", passT);


		}
		if (passT != "Player_Spawn")
		{
			canKill = true;
		}





	}

	void Kill(){
		Destroy(transform.gameObject);
	}
}
