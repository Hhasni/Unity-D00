using UnityEngine;
using System.Collections;

public class Scenery : MonoBehaviour {
	
	public float		moveSpeed;
	public flappy 		my_bird;

	// Use this for initialization
	void Start () {
		moveSpeed = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (my_bird.alive == true)
			transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
	}
}
