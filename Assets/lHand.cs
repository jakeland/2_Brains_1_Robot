using UnityEngine;
using System.Collections;

public class lHand : MonoBehaviour {
	int layerMask = 1 << 9;
	LineRenderer line;

	public Transform rightHand;
	private bool fire = false;
	void Awake(){
		layerMask = ~layerMask;
		line = gameObject.GetComponent<LineRenderer>();
		line.enabled= false;

	}

	void Update(){

		if (fire)
		{
			pew ();
			fire = false;
		}
		else 
			line.enabled =false;


	}
	
	void help(){

		rightHand.SendMessage ("FireRight");
	}
	// Use this for initialization
	void FireLeft(){


		fire = true;


	}


	void pew()
	{

		line.enabled = true;
		Ray2D ray = new Ray2D(transform.position, transform.up);
		RaycastHit2D hit = Physics2D.Raycast(transform.position,ray.direction, Mathf.Infinity, layerMask);
		

		line.SetPosition(0, ray.origin);
		if(hit.collider != null)
		{
			
			line.SetPosition (1, hit.point);
			
			if (hit.collider.tag == "Enemy")
				hit.collider.SendMessage ("hurt");
			if (hit.collider.tag == "Cage")
				hit.collider.SendMessage ("hurt");
			
			
			
			
			
			
		}
		else
		{
			
			line.SetPosition (1, ray.GetPoint(Mathf.Infinity));

		}




	}
}
