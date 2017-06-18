using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameTest : MonoBehaviour {
    public Transform target;
    public float rotate_speed = 5f;
	public float move_speed = 10f;
    void Update() {
        //Vector2 direction = target.position - transform.position;
        //float angle = Mathf.Atan2(direction.y,direction.x) * Mathf.Rad2Deg;
        //Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        //transform.rotation = Quaternion.Slerp(transform.rotation, rotation , rotate_speed*Time.deltaTime);
		transform.position = Vector3.MoveTowards(transform.position, target.position, move_speed*Time.deltaTime);
    }
}
