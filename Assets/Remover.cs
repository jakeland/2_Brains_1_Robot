using UnityEngine;
using System.Collections;

public class Remover : MonoBehaviour {

	// Use this for initialization
	void Kill(){
		Destroy (transform.gameObject);

	}
}
