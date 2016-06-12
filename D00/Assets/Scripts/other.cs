using UnityEngine;
using System.Collections;

public class other : MonoBehaviour {
	
	public Vector3 		oriPos;
	public GameObject 	obj;
	// Use this for initialization
	void Start () {
		oriPos = obj.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < -5.6) {
			transform.position = oriPos;
		}
	}
}
