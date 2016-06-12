using UnityEngine;
using System.Collections;

public class BallPong : MonoBehaviour {
	public int 			i;
	public int 			j;
	public int 			ptsp1;
	public int 			ptsp2;
	public bool 		hitp1;
	public bool 		hitp2;
	public GameObject 	p1;
	public GameObject 	p2;
	public GameObject 	mu;
	public GameObject 	md;
	public float		moveSpeed;
	public Vector3		OriPos;
	public bool 		isout;
	// Use this for initialization
	void Start () {
		ptsp1 = 0;
		ptsp2 = 0;
		ft_init ();
	}

	void ft_init(){
		OriPos = transform.position;
		//Debug.Log (Random.Range (1, 3));
		i = Random.Range (1, 3);
		j = Random.Range (1, 3);
		if (i == 2)
			i = -1;
		if (j == 2)
			j = -1;
		isout = false;
		moveSpeed = 5;
		hitp1 = false;
		hitp2 = false;
	}
	
	void ft_touch_player () {
		if (transform.position.y <= (p1.transform.position.y + 1.5) && transform.position.y >= (p1.transform.position.y - 1.5)) {
			if (transform.position.x <= (p1.transform.position.x + 0.45) && transform.position.x >= (p1.transform.position.x)) {
				if (hitp1 == false) {
					i = -i;
					hitp1 = true;
					hitp2 = false;
				}
			}
		} else if (transform.position.y <= (p2.transform.position.y + 1.5) && transform.position.y >= (p2.transform.position.y - 1.5)) {
			if (transform.position.x >= (p2.transform.position.x - 0.45) && transform.position.x <= (p2.transform.position.x)) {
				if (hitp2 == false) {
					i = -i;
					hitp2 = true;
					hitp1 = false;
				}
			}
		}
	}

	void ft_touch_wall () {
		if (transform.position.y >= (mu.transform.position.y - 0.45)) {
			hitp1 = false;
			hitp2 = false;
			j = -j;
		} else if (transform.position.y <= (md.transform.position.y + 0.45)) {
			hitp1 = false;
			hitp2 = false;
			j = -j;
		}
	}

	void ft_check_pts(){
		if (isout == true) {
			Debug.Log("Player 1: " + ptsp1 + " | Player 2 : " +  ptsp2);
			transform.position = OriPos;
			ft_init ();
		}
	}

	void ft_check_out(){
		if (transform.position.x < -13) {
			isout = true;
			ptsp2 += 1;
		}
		if (transform.position.x > 13) {
			isout = true;
			ptsp1 += 1;
		}

	}
	// Update is called once per frame
	void Update () {
		ft_touch_player ();
		ft_touch_wall ();
		ft_check_out ();
		ft_check_pts ();
		transform.Translate (new Vector3 (i, j, 0) * moveSpeed * Time.deltaTime);
	}
}
