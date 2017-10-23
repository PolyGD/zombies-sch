using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class persoscriptmovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print("begin");
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		if (Input.GetKeyDown ("w")) {
			transform.Translate(new Vector3(0,0,Time.deltaTime * 1));
		}
	}
}
