using UnityEngine;
using System.Collections;

public class PaletteScript : MonoBehaviour {
	
	public GameObject 	p1;
	public GameObject 	p2;
	public float		moveSpeed;

	// Use this for initialization
	void Start () {
		moveSpeed = 15;
	}

	void ft_move_p1 () {
		if (Input.GetKey (KeyCode.W) && p1.transform.position.y < 8.50)
			p1.transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
		if (Input.GetKey (KeyCode.S) && p1.transform.position.y > -8.50)
			p1.transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
	}

	void ft_move_p2 () {
		if (Input.GetKey (KeyCode.UpArrow) && p2.transform.position.y < 8.50)
			p2.transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
		if (Input.GetKey (KeyCode.DownArrow) && p2.transform.position.y > -8.50)
			p2.transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
	}

	// Update is called once per frame
	void Update () {
		ft_move_p1 ();
		ft_move_p2 ();
	}
}
