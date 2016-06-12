using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour {
	
	public GameObject	final_touch;
	public GameObject	touch_a;
	public GameObject	touch_d;
	public GameObject	touch_s;
	public GameObject	clone;
	public float 		timer;
	public float		spawnTime;
	public int 			rand;
	public Vector3 		newPos;
	// Use this for initialization
	void Start () {
		timer = 0;
		spawnTime = 4;
		rand = 0;
	}
	// Update is called once per frame
	void Update () {
	
		if (timer >= Random.Range(2, 6)) {
			timer = 0;
			//Destroy (clone);
			rand = Random.Range(0, 3);
//			Debug.Log (rand);
			if (rand == 0) {
				newPos = new Vector3 (-2, 4, 1);
				final_touch = touch_a;
			}
			else if (rand == 1) {
				newPos = new Vector3 (0, 4, 1);
				final_touch = touch_s;
			}
			else {
				newPos = new Vector3 (2, 4, 1);
				final_touch = touch_d;
			}
			clone = GameObject.Instantiate (final_touch, newPos, Quaternion.identity) as GameObject;
		//	Debug.Log (newPos);
		}
		timer += Time.deltaTime;
//		Debug.Log ("timer = " + timer);
	}

}
