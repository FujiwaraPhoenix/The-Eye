using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Lets us talk to buttons
using UnityEngine.UI;

public class ExitButtonScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.GetComponent<Button>().onClick.AddListener(TaskOnClick);
	}

	//Plays whenever the button is clicked
	void TaskOnClick () {
		Application.Quit ();
	}
}
