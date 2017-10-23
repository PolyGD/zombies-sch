using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {
	Collider collider;
	Quaternion oldHead;
	Quaternion oldBody;
	Transform head;
	Transform body;
	// Use this for initialization
	void Start () {
		collider = GetComponent<Collider>();
		head = transform.parent;
		body = head.parent;
	}
	
	// Update is called once per frame
	void Update () {
		
		oldHead = head.localRotation;
		 
		oldBody = body.localRotation;

		Vector3 pos = transform.localPosition;
		Vector3 futurePos = pos+ (new Vector3(0,0,Input.GetAxis("Mouse ScrollWheel")));
		if(futurePos.z < -1.25 && futurePos.z>-4) {
			transform.Translate (new Vector3(0,0,Input.GetAxis("Mouse ScrollWheel")));
		}


			head.Rotate (new Vector3(-180*Input.GetAxis ("Mouse Y") * Time.deltaTime,0,0));
			body.Rotate (new Vector3(0,180*Input.GetAxis ("Mouse X") * Time.deltaTime,0));


	}
	void OnTriggerStay(Collider other) {
		head.localRotation=oldHead;
		body.localRotation=oldBody;
	}

}
