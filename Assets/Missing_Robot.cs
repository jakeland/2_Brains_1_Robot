using UnityEngine;
using System.Collections;

public class Missing_Robot : MonoBehaviour {
	bool notCaptured = false;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (notCaptured == true) {
			leave();
		}

	}

	void freedom() {
		notCaptured = false;
		}


	void leave(){
		//doesn't do anything yet;
		
		}
}
