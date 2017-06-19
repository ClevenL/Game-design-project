using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogHolder : MonoBehaviour {

	public string dialogue;
	private DialogueManager dMan;
	public static QuestTrigger qTrig;
	private QuestManager theQM;
	public float distance;
	public string[] dialogueLines;
	public GameObject NPC;
	public GameObject Player;

	// Use this for initialization
	void Start () {
		dMan = FindObjectOfType<DialogueManager>();
		qTrig = FindObjectOfType<QuestTrigger> ();
		theQM = FindObjectOfType<QuestManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		distance = Vector3.Distance(Player.transform.position, NPC.transform.position);
		if (distance <= 0.6) {




			if (Input.GetKeyUp (KeyCode.E)) {
				//dMan.ShowBox (dialogue);

				if (!dMan.dialogActive) {
					//Debug.Log ("siin1");
					if (Player.name == "Player" && NPC.name == "Normak" && theQM.questCompleted [2] == false &&
					    theQM.questCompleted [0] == true) {


						//Debug.Log ("siin2");
						//theQM.quests [2].EndQuest ();
						//theQM.ShowQuestText (endText);
						theQM.questCompleted [2] = true;
						ScoreScript.scoreValue += 4;
						theQM.quests [2].gameObject.SetActive (false);



						dMan.dialogLines = dialogueLines;
						dMan.currentLine = 0;
						dMan.ShowDialogue ();

					} else if (Player.name == "Player" && NPC.name == "Romil" && theQM.questCompleted [0] == false) {
						//theQM.quests [2].EndQuest ();
						//theQM.ShowQuestText (endText);
						qTrig.gameObject.SetActive (false);
						theQM.questCompleted [0] = true;
						theQM.quests [0].gameObject.SetActive (false);
						ScoreScript.scoreValue += 4;
						theQM.quests [2].gameObject.SetActive (true);



						dMan.dialogLines = dialogueLines;
						dMan.currentLine = 0;
						dMan.ShowDialogue ();

					} else if (theQM.questCompleted [1] == false && theQM.questCompleted [2] == false) {
						theQM.ShowQuestText ("Mul ei ole sulle midagi öelda.");
					} else {

						theQM.ShowQuestText ("Mul ei ole sulle midagi öelda.");
					}
						

				}
			}
		

		} else {
			NPC.GetComponentInChildren<Renderer> (false);
			//NPC.GetComponent<SpriteRenderer> ().gameObject.SetActive (true);
		}
	}
}
