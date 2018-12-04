using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class levelControl : MonoBehaviour {
	Rigidbody2D player;
	public GameObject gameoverPanel;
	public GameObject pausePanel;
	public GameObject homeBut,bestIcone;
	public Text scoreText;
	int score=0;
	int highScore;

	// Use this for initialization
	void Start () {

		player=GameObject.FindGameObjectWithTag ("Player").GetComponent <Rigidbody2D>();
		Time.timeScale = 1;
		highScore= PlayerPrefs.GetInt ("HighScore");


	}
	
	// Update is called once per frame
	void Update () {
		//uses the p button to pause and unpause the game
		if(Input.GetKeyDown(KeyCode.P))
		{
			if(Time.timeScale == 1)
			{
				Pause();
			} else if (Time.timeScale == 0){
				Resume();
			}
		}



	}

	public void gameOver(){
		Time.timeScale = 0;
		player.velocity = Vector3.zero;
		gameoverPanel.SetActive(true);
		homeBut.SetActive(true);
		if (score > highScore)
			PlayerPrefs.SetInt ("HighScore", score);
	}
	public void Pause(){
		Time.timeScale = 0;
		pausePanel.SetActive(true);
		homeBut.SetActive(true);

	}
	public void Resume(){
		Time.timeScale = 1;
		pausePanel.SetActive(false);
		homeBut.SetActive(false);


	}
	public void Reload(){
		Application.LoadLevel(Application.loadedLevel);
	}
	public void goHome(){
		//load home scene 
		//Application.LoadLevel(/*Application.loadedLevel*/);
	}
	public void addScore(int scoreToAdd){
		score += scoreToAdd;
		scoreText.text = score+"";
		if (score > highScore) {
			bestIcone.SetActive (true);
		}
	}
}
