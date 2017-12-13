using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainSceneController : MonoBehaviour {
	public static float runningTheGame;
	public static bool isRestarted;



	// Use this for initialization
	void Start () {
		
	}

	public void NextScene()
	{
		SceneManager.LoadScene("StartingScene");


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}


