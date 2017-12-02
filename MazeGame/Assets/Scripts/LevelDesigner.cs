using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDesigner : MonoBehaviour {

	// Use this for initialization
	public Transform brick;
	void Start () {
		InitializeLevel ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void InitializeLevel()
	{
		for (int i = 0; i < 35; i++) {
			int x, y;
			x = Random.Range (-400, 400);
			y=Random.Range(-300,300);
		Instantiate(brick, new Vector3(x/100, y/100, 0), Quaternion.identity);
		}
	}
}
