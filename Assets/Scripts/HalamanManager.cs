using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HalamanManager : MonoBehaviour {

	public bool isEscapeToExit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Escape)) {
			if (isEscapeToExit) {
				Application.Quit ();
			} else {
				KembaliKeMenu ();
			}
		}
	}

	public void MulaiPermainan() {
		SceneManager.LoadScene ("Main");
	}

	public void KembaliKeMenu() {
		SceneManager.LoadScene ("Menu");
	}
}
