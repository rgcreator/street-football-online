﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
	public float movespeed;
	// Use this for initialization
	void Start () {
		movespeed = 15f;	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (movespeed * Input.GetAxis ("Horizontal") * Time.deltaTime, 0f, movespeed * Input.GetAxis ("Vertical") * Time.deltaTime);
	}
}
