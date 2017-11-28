using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Player : NetworkBehaviour {
	private Camera _Camera;
	// Use this for initialization
	//FOR MORE COMPLEXITY, CHECK DOCS: https://docs.unity3d.com/Manual/UNetSetup.html
	void Start () {
//		GetComponent<MeshRenderer>().material.color = new Color (Random.Range (0, 255), Random.Range (0, 255), Random.Range (0, 255));
		GetComponent<MeshRenderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
		_Camera = Camera.main.gameObject.GetComponent<Camera> ();
		Camera.main.gameObject.GetComponent<Camera> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (isLocalPlayer) {
			transform.Translate (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
		}
	}

	void OnDestroy() {
		_Camera.enabled = true;
	}
}
