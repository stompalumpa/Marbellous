﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LastScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	    if (Input.GetKey(KeyCode.Escape)) SceneManager.LoadScene(0);

	}
}
