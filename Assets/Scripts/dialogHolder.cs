using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dialogHolder : MonoBehaviour {

	public string dialogue;
	private DialogueManager dMan;
	public static QuestTrigger qTrig;
	private QuestManager theQM;
	public float distance;
	public string[] dialogueLines;
	public GameObject NPC;
	public GameObject Player;
	//private int skipper = 1;

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

			if (!dMan.dialogActive && Player.name == "Player" && NPC.name == "Inga" &&
				theQM.questCompleted [2] == true && ProgressSave.skipper == 2) {
				ProgressSave.skipper = 3;
				SceneManager.LoadScene ("Minigame4");

			}

			if (ProgressSave.skipper == 4){
				theQM.quests [3].gameObject.SetActive (true);
				Debug.Log(RightAnswer.answer);
				if(RightAnswer.answer){
					theQM.ShowQuestText ("Tubli! Sa teenisid 25 EAP.");
					ScoreScript.scoreValue += 25;
				}else{
					theQM.ShowQuestText ("Sa ei vastanud õigesti ja kukkusid aine läbi.");
				}

			}



			if (Input.GetKeyUp (KeyCode.E)) {
				//dMan.ShowBox (dialogue);

				if (!dMan.dialogActive) {
					//Debug.Log ("siin1");
					if (Player.name == "Player" && NPC.name == "Inga" && theQM.questCompleted [2] == false &&
					    theQM.questCompleted [0] == true) {


						dMan.dialogLines = dialogueLines;
						dMan.currentLine = 0;
						dMan.ShowDialogue ();

						//Debug.Log ("siin2");
						//theQM.quests [2].EndQuest ();
						//theQM.ShowQuestText (endText);
						theQM.questCompleted [2] = true;
						ProgressSave.questProgress [2] = true;
						//ScoreScript.scoreValue += 4;
						theQM.quests [2].gameObject.SetActive (false);
						ProgressSave.skipper = 2;





					} else if (Player.name == "Player" && NPC.name == "Normak" && theQM.questCompleted [0] == false) {
						//theQM.quests [2].EndQuest ();
						//theQM.ShowQuestText (endText);
						qTrig.gameObject.SetActive (false);
						theQM.questCompleted [0] = true;
						ProgressSave.questProgress [0] = true;
						theQM.quests [0].gameObject.SetActive (false);
						theQM.quests [2].gameObject.SetActive (true);
						//ScoreScript.scoreValue += 6;



						dMan.dialogLines = dialogueLines;
						dMan.currentLine = 0;
						dMan.ShowDialogue ();
					
					} else if (Player.name == "Player" && NPC.name == "heinrich"){
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
