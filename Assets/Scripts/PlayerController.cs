using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;
	private Animator a;
	private DialogueManager dMan;
	private bool playerMoving;
	private Vector2 lastMove;


	void Start () {
		a=GetComponent<Animator>();
		dMan = FindObjectOfType<DialogueManager>();

	}

	void Update () {
		float Horizontal = Input.GetAxisRaw ("Horizontal");
		float Vertical = Input.GetAxisRaw("Vertical");
		playerMoving=false;

		if (dMan.dialogActive == false) {

			if(Horizontal>0.5f || Horizontal<-0.5f){
				transform.Translate(new Vector3(Horizontal*moveSpeed*Time.deltaTime,0f,0f));
				playerMoving=true;
				lastMove=new Vector2(Horizontal,Vertical);
			}
			if(Vertical>0.5f || Vertical<-0.5f){
				transform.Translate(new Vector3(0f,Vertical*moveSpeed*Time.deltaTime,0f));
				playerMoving=true;
				lastMove=new Vector2(Horizontal, Vertical);
			}

			a.SetFloat("MoveX",Horizontal);
			a.SetFloat("MoveY",Vertical);
			a.SetBool("PlayerMoving",playerMoving);
			a.SetFloat("LastMoveX",lastMove.x);
			a.SetFloat("LastMoveY",lastMove.y);

		}

	}

}
