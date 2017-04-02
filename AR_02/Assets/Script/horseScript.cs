using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horseScript : MonoBehaviour {

	private Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void run(){
		anim.SetBool ("isWork", false);
		anim.SetBool("isRun", true);
	}

	public void walk(){
		anim.SetBool ("isRun", false);
		anim.SetBool("isWork", true);
	}
}
