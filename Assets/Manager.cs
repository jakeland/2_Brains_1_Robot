using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {
	private float currLevel;

	private bool levelComplete = false;
	private GameObject[] spawners;

	// Use this for initialization
	void Awake () {
		DontDestroyOnLoad(transform.gameObject);
		}
	void OnLevelWasLoaded(int level) {

						spawners = GameObject.FindGameObjectsWithTag ("Spawn");
				
		if (spawners != null) {
						foreach (GameObject spawner in spawners) {
						
								spawner.SendMessage ("Spawn");
						}
				}
		}

	
	// Update is called once per frame
	void Update () {
	
		if (levelComplete == true) {
			//do things that load next level
				}
	}

	void Complete() {
		levelComplete = true;
		}
}
