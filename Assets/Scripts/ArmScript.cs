using UnityEngine;
using System.Collections;

public class ArmScript : MonoBehaviour {

	public Transform armL;
	public Transform armR; 
	public float speed = 80f;

	private float rtl = 0f; //rotation tracker left
	private float rtr = 0f; //rotation tracker right

	void FixedUpdate(){
		 
		float rml = 0f;//rotation modifier left

		float rmr = 0f;//rotation modifier right



		if (Input.GetButton ("ArmLB"))
						rml = -1;
	if (Input.GetButton ("ArmLF"))
						rml = 1;

	if (Input.GetButton ("ArmRF"))
					rmr = -1;
		if (Input.GetButton ("ArmRB"))
						rmr = 1;



		rtl += Time.deltaTime * rml * speed;
		rtr += Time.deltaTime * rmr * speed;

		if (rtl < 0)
						rtl = 0;
		if (rtr > 0)
						rtr = 0;
		if (rtl > 180)
						rtl = 180;
		if (rtr < -180)
						rtr = -180;



		if (((rtl + Time.deltaTime * rml) > 0) && ((rtl + Time.deltaTime * rtl) < 180)) {
						armL.transform.Rotate  (0, 0, rml * Time.deltaTime * speed);
			}
		if (((rtr + Time.deltaTime * rmr) > -180) && ((rtr + Time.deltaTime * rtr) < 0)) {
						armR.transform.Rotate (0, 0, rmr * Time.deltaTime * speed);
				}



	}
	

	


	void Update(){

	}



}
