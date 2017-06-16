using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressE : MonoBehaviour {
	public float distance;
	public GameObject NPC;
	public GameObject Player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		distance = Vector3.Distance(Player.transform.position, NPC.transform.position);
		if (distance <= 0.6) {
			GetComponent<Renderer> ().enabled = true;
		} else {
			GetComponent<Renderer> ().enabled = false;
		}
	}
}
