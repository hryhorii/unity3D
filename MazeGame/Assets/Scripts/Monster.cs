using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour {

	// Use this for initialization
	public int type=1;
	private float speed=0.5f;
	private float baseSpeed=0.5f;
	private int direction;
	private GameObject target;
	private SpriteRenderer sr;
	//1 is zombie & 2 is mummy
	void Start () {
		sr = GetComponent<SpriteRenderer> ();
		target = GameObject.FindGameObjectWithTag ("Player");
		if (type == 1) 
			speed = 0.5f;
		else
			speed = 1.0f;
		baseSpeed = speed;
		direction = Random.Range (0, 2);

		
	}

	// Update is called once per frame
	void Update () {
		if (GlobalClass.Instance.score > 20) {
			int increaseFactor = GlobalClass.Instance.score - 20;
			float increasedSpeed = increaseFactor*(baseSpeed * 5 / 100);
			speed = baseSpeed+increasedSpeed;
			if (speed > 1.8f)
				speed = 1.8f;
		}
		if (GlobalClass.Instance.score<20) {
			Vector3 move;
			if (direction == 0) {
				move = new Vector3 (-1, 0, 0);
				sr.flipX = false;

			} else {
				move = new Vector3 (1, 0, 0);
				sr.flipX = true;
			}
			transform.position += move * speed * Time.deltaTime;
		} else {
			float step = speed * Time.deltaTime;
			if (transform.position.x > target.transform.position.x)
				sr.flipX = false;
			else
				sr.flipX = true;
			transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.CompareTag("Player"))
		{
			GlobalClass.Instance.isGameOver = true;
			GlobalClass.Instance.gameOverReason = 1;
			Debug.Log ("Game Over");

		}
		if (other.gameObject.CompareTag ("Border")) {
			if (direction == 0) {
				direction = 1;
			} else {
				direction = 0;
			}
		}
	}
}
