using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk_and_Run : MonoBehaviour {
	public Animator animator;
	void Start(){
		animator = GetComponent<Animator> ();
	}
	void Update () {
		if (Input.GetKey("up")|Input.GetKey("down")|Input.GetKey("left")|Input.GetKey("right")|Input.GetKey("w")|Input.GetKey("a")|Input.GetKey("s")|Input.GetKey("d")) 
		{
			Walk ();
		} else {
			Idle();
		}
}
	public void Walk()
	{
	animator = GetComponent<Animator> ();
	animator.SetBool ("Walk", true);
	animator.SetBool ("SprintJump", false);
	animator.SetBool ("SprintSlide", false);
}
	public void Idle ()
	{	animator = GetComponent<Animator>();
		animator.SetBool ("Walk", false);
		animator.SetBool ("SprintJump", false);
		animator.SetBool ("SprintSlide", false);
	}
}