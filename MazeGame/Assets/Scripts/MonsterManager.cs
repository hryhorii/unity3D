using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterManager : MonoBehaviour {

	// Use this for initialization
	public Transform zombie,mummy;
	private bool isZombieLimit, isMummyLimit;
	void Start () {
		 CreateZombie();
	}
	
	// Update is called once per frame
	void Update () {
		if (GlobalClass.Instance.score == 5) {
			if (!isZombieLimit) {
				CreateZombie ();
				isZombieLimit = true;
			}
		}
		if (GlobalClass.Instance.score == 10) {
			if (!isMummyLimit) {
				CreateMummy ();
				isMummyLimit = true;
			}
		}
	}
	void CreateZombie()
	{
		int x, y;
		x = Random.Range (0, 400);
		y = Random.Range (-300, 300);
		Instantiate (zombie, new Vector3 (x / 100, y / 100, 0), Quaternion.identity);
	}
	void CreateMummy()
	{
		int x, y;
		x = Random.Range (0, 400);
		y = Random.Range (-300, 300);
		Instantiate (mummy, new Vector3 (x / 100, y / 100, 0), Quaternion.identity);
	}
}
