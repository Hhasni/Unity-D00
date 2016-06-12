using UnityEngine;
using System.Collections;

public class pipe : MonoBehaviour {

	public Vector3 		oriPos;
	public flappy 		BirdScript;
	public Scenery 		SceneScript;
	// Use this for initialization
	void Start () {
		oriPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < 0.8) {
			transform.position = oriPos;
			BirdScript.Score = BirdScript.Score + 5;
			SceneScript.moveSpeed = SceneScript.moveSpeed + 0.2f;
		}
	}
}