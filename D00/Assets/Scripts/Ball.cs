using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	
	public	float 			x;
	public	float 			y;
	public	int 			count;
	public	bool 			status;
	
	public  Club 			my_club;
	Vector3 endPos;
	// Use this for initialization
	void Start () {
		count = 0;
		x = transform.position.x;
		y = transform.position.y;	
	}
	
	// Update is called once per frame
	public void move () {
		status = true;
		count = my_club.count / 2;
		endPos = transform.position + (transform.up * count * 5);

	}
	void Update () {
		if (status) {
			transform.position = Vector3.Lerp (transform.position, endPos, Time.deltaTime * 2);
//			Debug.Log("endPos = " + endPos);
//			Debug.Log("transform.position = " + transform.position);
			y = transform.position.y;	
			if (transform.position.y >= (endPos.y - 0.5)  && transform.position.y <= (endPos.y + 0.5)) {
				my_club.status = true;
				my_club.ft_replace(transform.position.y);
				status = false;
			}
//			Debug.Log("y ==" + y);
			if (y >=  3.45 && y <= 3.52){
				Destroy (gameObject);
				my_club.win = true;
			}
		}
		if ((float)transform.position.y > 4.5 || (float)transform.position.y < -4.5){
			count /= 4;
			Vector3 pos;
			if (transform.position.y >= 4.5){
				pos = new Vector3 (0, (float)4.5, 0);
				transform.position = pos;
				endPos = transform.position - (transform.up * count * 10);;
			}
			else{
				pos = new Vector3 (0, (float)-4.5, 0);
				transform.position = pos;
				endPos = transform.position + (transform.up * count * 10);
			}
			status = true;
		}
//		Debug.Log ("ball x = " + x);
//		Debug.Log ("ball y = " + y);
	}
}
