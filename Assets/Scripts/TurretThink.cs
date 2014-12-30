using UnityEngine;
using System.Collections;

public class TurretThink : MonoBehaviour {

	public Transform turret_barrel;
	private float rt = 0f; //rotation tracker for the barrel
 	
	private float rm = 1; //rotation modifier
	public float speed = 80; //rotation speed
	
	// Update is called once per frame
	void Update () {

		 if(rt >= 45)
		{
			rt = 45;
			rm = -1;

		}
		if (rt <= -45)
		{
			rt = -45;
			rm = 1;
		}
	
		rt += rm * Time.deltaTime * speed;

		if (((rt + Time.deltaTime * rm) > -45) && ((rt + Time.deltaTime * rt) < 45)){
			turret_barrel.transform.Rotate(0,0,rm * Time.deltaTime*speed);

		}
	}
}
