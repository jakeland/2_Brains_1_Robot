using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour {

	Color Color1 = new Color(1f, 1f, 1f, 1f);
	Color Color2 = Color.green;

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<SpriteRenderer>().color = Color1;
	}
	
	// Update is called once per frame
	void Update () {
		


	}

	void OnMouseOver () {
		gameObject.GetComponent<SpriteRenderer>().color = Color2;
	}

	void OnMouseExit() {
		gameObject.GetComponent<SpriteRenderer>().color = Color1;
	}

	void OnMouseDown () {
		Application.LoadLevel ("Level_01");
	}
}
