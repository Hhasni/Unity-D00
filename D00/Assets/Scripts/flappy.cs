using UnityEngine;
using System.Collections;

public class flappy : MonoBehaviour {
	public int			downSpeed;
	public int			rotSpeed;
	public int			Score;
	public float 		timer;
	public float 		GameTime;
	public float 		jumpTime;
	public bool 		down;
	public bool 		up;
	public bool 		alive;
	public GameObject 	pipe;
	// Use this for initialization
	void Start () {
		jumpTime = 0.3f;
		timer = 0;
		down = false;
		up = false;
		alive = true;
		downSpeed = 4;
		rotSpeed = 50;
	}
	
	void ft_move(){
		if (up == true && timer < jumpTime)
			transform.Translate (Vector3.up * downSpeed * Time.deltaTime);
		else {
			timer = 0;
			up = false;
			transform.Translate (Vector3.down * downSpeed * Time.deltaTime);
		}
	}

	void ft_death(){
		if (transform.rotation.z > -0.70)
			transform.Rotate (Vector3.back * 600 * Time.deltaTime);
		else if (transform.position.y > -10) {
			transform.Translate (Vector3.right * 15 * Time.deltaTime);
		}
	}

	void ft_finish(){
		alive = false;
		Debug.Log ("Score: " + Score);
		Debug.Log ("Time: " + Mathf.RoundToInt(GameTime) +"s");
	}


	void ft_touchdown(){
		//	Debug.Log (transform.position.x);
		//Debug.Log (pipe.transform.position.x);
		if (transform.position.y <= -3.79)
			ft_finish();
		if (transform.position.x >= (pipe.transform.position.x - 1.1) && transform.position.x <= (pipe.transform.position.x + 1.1)) {
			if (transform.position.y > 1.55 || transform.position.y < -1.45)
				ft_finish();
				//Debug.Log (transform.position.y);
		}
	}

	// Update is called once per frame
	void Update () {
		//Debug.Log (transform.rotation.z);
		if (alive == true) {
			ft_touchdown ();
			ft_move ();
			if (Input.GetKeyDown (KeyCode.Space)) {
				if (timer < jumpTime)
					timer = 0;
				up = true;
			} else
				down = true;
			GameTime += Time.deltaTime;
			timer += Time.deltaTime;
		} else
			ft_death ();
	}

}

