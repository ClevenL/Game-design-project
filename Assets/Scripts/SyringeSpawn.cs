using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyringeSpawn : MonoBehaviour {
	public GameObject syringe;
	GameObject syringeClone;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 spawnPos = new Vector3(Random.Range(-3f, 3f), 3f);
		//syringeClone = Instantiate(syringe, new Vector3(Random.Range(-3f, 3f), 3f)) as GameObject;
	}
}
