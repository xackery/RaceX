﻿using UnityEngine;
using System.Collections;

public class ProfileController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public string stringToEdit = "Hello World";
	void OnGUI() {
		stringToEdit = GUI.TextField(new Rect(10, 10, 200, 20), stringToEdit, 25);
	}
}
