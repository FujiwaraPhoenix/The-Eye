using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Lets us talk to scenes
using UnityEngine.SceneManagement;

//Lets us talk to buttons
using UnityEngine.UI;

public class StartButtonScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.GetComponent<Button>().onClick.AddListener(TaskOnClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void TaskOnClick() {
		SceneManager.LoadScene ("TheEye1");
	}
}
