using UnityEngine;
using System.Collections;

public class baloon : MonoBehaviour {
	
	public int 		blow;
	public int 		oxy;
	public int 		max_oxy;
	public int 		recover;
	public int 		overburn;
	public float	size;
	public float	max_size;
	public float    tmp;

	Animator anim;
	// Use this for initialization
	void Start () {
		oxy = 1000;
		max_oxy = 1000;
		blow = 30;
		recover = 1;
		overburn = 0;
		size = 1.0f;
		max_size = 3.10f;
		tmp = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (size > 0)
			size -= 0.005f;
		if (oxy < max_oxy)
			oxy += recover;
		if (size <= 0){
			size = 0;
			Debug.Log ("***EXPLOSION***");
			Debug.Log ("YOU LOSE");
			Debug.Log ("Baloon life time: " +  Mathf.RoundToInt(Time.realtimeSinceStartup) + "s");
			Destroy (gameObject);
		}
		if (size >= max_size) {
			size = max_size;
			Debug.Log ("***EXPLOSION***");
			Debug.Log ("YOU WIN");
			Debug.Log ("Baloon life time: " + Mathf.RoundToInt (Time.realtimeSinceStartup) + "s");
			Destroy (gameObject);
		}
		if (Input.GetKeyDown ("space") && oxy > blow) {
			overburn = 0;
			if ((Time.realtimeSinceStartup - tmp) < 0.10F)
			{
				Debug.Log("overburn");
				overburn = 30;
			}
			Debug.Log ("plop = " + (Time.realtimeSinceStartup - tmp));
//			Debug.Log ("space key was pressed");
			oxy = ((oxy - blow) > 0) ? oxy -= (blow + overburn): 0;
			size += 0.1F;
			tmp = Time.realtimeSinceStartup;
		}
		transform.localScale = new Vector3(size, size, 0);
	}
}
