using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {


	private bool levelComplete = false;
	private GameObject[] spawners;
	private GameObject NPCBot;
	private string nextLevel;
	// Use this for initialization
	void Awake () {
		DontDestroyOnLoad(transform.gameObject);
		}
	void OnLevelWasLoaded(int level) {
		switch (level) {
		case 1:
			nextLevel = "level_02";
			break;
		case 2:
			nextLevel = "level_03";
			break;
		case 3:
			nextLevel = "level_04";
			break;
		case 4:
			nextLevel = "level_05";
			break;
		case 5:
			nextLevel = "level_06";
			break;
		case 6:
			nextLevel = "outro";
			break;
		default:
			break;

				}
						spawners = GameObject.FindGameObjectsWithTag ("Spawn");
				
		if (spawners != null) {
						foreach (GameObject spawner in spawners) {
						
								spawner.SendMessage ("Spawn");
						}
				}
		NPCBot = GameObject.FindGameObjectWithTag ("NPCBot");
		}

	
	// Update is called once per frame
	void Update () {
	
		if (levelComplete == true) {
			levelComplete = false;
			Application.LoadLevel(nextLevel);
				}
	}

	void Complete() {
		levelComplete = true;
		}

	void RobotFree () {
		NPCBot.SendMessage ("Leave");


		}


}
