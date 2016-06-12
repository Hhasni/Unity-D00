using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour {
	
	public int			moveSpeed;
	public int			type;
	public float		tmp;
	public bool			over;
	// Use this for initialization
	void Start () {
		moveSpeed = Random.Range(3,7);
		over = false;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
		if (Input.GetKeyDown (KeyCode.A) && type == 0 && transform.position.y < 0.3) {
			Destroy (gameObject);
			Debug.Log ("Precision: " + tmp + "%");
		}
		if (Input.GetKeyDown (KeyCode.S) && type == 1 && transform.position.y < 0.3) {
			Destroy (gameObject);
			Debug.Log ("Precision: " + tmp + "%");
		}
		if (Input.GetKeyDown (KeyCode.D) && type == 2 && transform.position.y < 0.3) {
			Destroy (gameObject);
			Debug.Log ("Precision: " + tmp + "%");
		}
		if (tmp < 100.0f) {
			tmp = transform.position.y;
			tmp = -(tmp - 4.0f) / (4.0f * 2) * 100;
		}
		if (tmp >= 100.0f || over == true)
			tmp -= moveSpeed;
		if (transform.position.y < -4.3) {
			Destroy (gameObject);
			Debug.Log ("Precision: 0%");
		}
	}
}
