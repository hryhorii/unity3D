using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	public float speed=2.0f;
	private SpriteRenderer sr;
	void Start () {
		sr = GetComponent<SpriteRenderer> ();
	}

	// Update is called once per frame
	void Update () {
		Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
		transform.position += move * speed * Time.deltaTime;

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			sr.flipX = true;
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			sr.flipX = false;
		}
		/*if (Input.GetKeyDown (KeyCode.UpArrow)) {
			transform.position += new Vector3 (0, 0.1f, 0);
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			transform.position -= new Vector3 (0, 0.1f, 0);
		}*/

	}
}
