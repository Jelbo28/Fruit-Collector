using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GM : MonoBehaviour 
{
	[SerializeField]
	int time = 0;
	[SerializeField]
	int score = 0;

	[SerializeField]
	Text timeText;
	[SerializeField]
	Text scoreText;
	[SerializeField]
	GameObject gameOver;
	[SerializeField]
	GameObject player;

	[SerializeField]
	static GM instance = null;

	AudioSource appleCollect;

	void Awake ()
	{
		timeText.text = "Time: 120";
		scoreText.text = "Score: 0";
		gameOver.SetActive (false);
		AudioSource[] audios = GetComponents<AudioSource> ();
		appleCollect = audios [0];

		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);

	}

	void CheckGameover()
	{
		if (time <= 0)
		{

		}
	}






}
