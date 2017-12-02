using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

	// Use this for initialization
	bool isDestroyed;
	int timer;
	void Start () {
		timer = 0;

	}


	// Update is called once per frame
	void Update () {
		if (!isDestroyed) {
			timer++;
			if (timer == 1500) {
				isDestroyed = true;
			}
		} else {
			GlobalClass.Instance.coins--;

			Destroy (this.gameObject);
			Destroy (this);
		}
	}


	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.CompareTag("Player"))
			{
				GlobalClass.Instance.score++;
			isDestroyed = true;

			}
	}
}
