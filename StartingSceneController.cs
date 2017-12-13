using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartingSceneController : MonoBehaviour {
	public static float timeBeforeStart;
	public static bool isStarted;



	// Use this for initialization
	void Start () {
		timeBeforeStart = 0.0f;
		isStarted = false;
	}


	public void NextScene()
	{
		SceneManager.LoadScene("MainScene");
		isStarted = true;
		GameController.eachGameTime = 60.0f + timeBeforeStart;
		GameController.turnTimer = 2.0f + timeBeforeStart;

//		print ("isStarted");
	}

	// Update is called once per frame
	void Update () {
		if (isStarted == false) {
			timeBeforeStart = Time.time;
		}

	}
}
