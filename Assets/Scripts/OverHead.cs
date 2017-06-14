using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverHead : MonoBehaviour {

	public Transform t;
	//public Transform g;


	// Use this for initialization
	void Start () {
		TextMesh textMesh = t.GetComponent (typeof(TextMesh)) as TextMesh;
		textMesh.text = "Tere";
		//t.GetComponent(TextMesh).text ="Tere";
		//g.GetComponent (TextMesh).text = "asd";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
