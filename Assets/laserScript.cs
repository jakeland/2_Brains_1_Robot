using UnityEngine;
using System.Collections;

public class laserScript : MonoBehaviour {
	int layerMask = 1 << 8;

	LineRenderer line;
	// Use this for initialization
	void Start () {
		layerMask = ~layerMask;
		line = gameObject.GetComponent<LineRenderer>();
		line.enabled= false;
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine ("pew");

	}

	IEnumerator pew()
	{
		line.enabled = true;
	Ray2D ray = new Ray2D(transform.position, transform.up);
		RaycastHit2D hit = Physics2D.Raycast(transform.position,ray.direction, 100f, layerMask);

	
		line.SetPosition(0, ray.origin);
		if(hit.collider != null)
		{

			line.SetPosition (1, hit.point);

			if (hit.collider.tag == "Player")
				hit.collider.SendMessage ("hurt");
			if (hit.collider.tag == "LeftHand")
				hit.collider.SendMessage ("help");
			if (hit.collider.tag == "RightHand")
				hit.collider.SendMessage ("help");
			



		}
		else
		{

	line.SetPosition (1, ray.GetPoint (100));
		}
		yield return null;
	}

}
