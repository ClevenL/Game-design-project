using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogHolder : MonoBehaviour {

	public string dialogue;
	private DialogueManager dMan;
	public float distance;
	public string[] dialogueLines;
	public GameObject NPC;
	public GameObject Player;

	// Use this for initialization
	void Start () {
		dMan = FindObjectOfType<DialogueManager>();
	}
	
	// Update is called once per frame
	void Update () {
		distance = Vector3.Distance(Player.transform.position, NPC.transform.position);
		if (distance <= 0.6) {

			if (Input.GetKeyUp (KeyCode.E)) 
			{
				//dMan.ShowBox (dialogue);

				if (!dMan.dialogActive) 
				{
					dMan.dialogLines = dialogueLines;
					dMan.currentLine = 0;
					dMan.ShowDialogue();
				}
			}
		

		}
	}
}
