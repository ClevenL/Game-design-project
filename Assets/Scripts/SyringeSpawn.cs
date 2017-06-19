using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyringeSpawn : MonoBehaviour {
	public GameObject syringe;
	//public GameObject finish;
	GameObject syringeClone;
	//GameObject finishClone;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(Random.Range(-3f, 3f), 4f);
		transform.rotation = Quaternion.Euler(0, 0, -90);
		syringeClone = Instantiate(syringe, transform.position, transform.rotation) as GameObject;
		//transform.position = new Vector3(transform.position.x, transform.position.y-7f);
		//finishClone = Instantiate(finish, transform.position, transform.rotation) as GameObject;
	}
}
