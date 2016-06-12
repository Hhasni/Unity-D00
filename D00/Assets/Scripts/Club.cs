using UnityEngine;
using System.Collections;

public class Club : MonoBehaviour {

	public Ball 	my_ball;
	public int 	 	count;
	public int 	 	pts;
	public float  	y;
	public float  	x;
	public bool 	loose;
	public bool 	win;
	public bool 	status;
	void Start () {
		count = 0;
		win = false;
		loose = false;
		status = true;
		pts = -15;
		x = transform.position.x;
		y = transform.position.y;
	}

	public void ft_replace (float y){
		Vector3 pos = new Vector3 (x ,y, 0);
		transform.position = pos;
	}
	// Update is called once per frame
	void Update () {
		if (win == false) {
			if (pts == 0 && loose == false) {
				Debug.Log ("You Loose");
				loose = true;
			}
//		Debug.Log ("transform.position.y - my_ball.y = " + (transform.position.y - my_ball.y));
			if (status == true) {
				if (Input.GetKeyDown (KeyCode.Space)) {
					transform.Translate (Vector3.down * 1 * Time.deltaTime);
					//			Debug.Log ("GetKeyDown");
				}
				if (Input.GetKey (KeyCode.Space)) {
					//			Debug.Log ("GetKey");
					if (count < 35) {
						count++;
						transform.Translate (Vector3.down * 1 * Time.deltaTime);
					}
				}
				if (Input.GetKeyUp (KeyCode.Space)) {
//					Debug.Log (pts);
					Vector3 pos = new Vector3 (transform.position.x, my_ball.transform.position.y, 0);
					transform.position = pos;
					my_ball.move ();
					count = 0;
					pts += 5;
					status = false;
				}
			}
		}
	}
}
