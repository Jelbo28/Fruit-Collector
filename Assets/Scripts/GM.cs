using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GM : MonoBehaviour 
{
    #region variables
    [SerializeField]
	int time = 0;
	[SerializeField]
	int score = 0;
    [SerializeField]
    float timeLeft;


    [SerializeField]
	Text timeText;
	[SerializeField]
	Text scoreText;
	[SerializeField]
	GameObject player;

	[SerializeField]
	static GM instance = null;

	AudioSource appleCollect;
    #endregion

    void Awake ()
	{
		timeText.text = "Time: 120";
		scoreText.text = "Score: 0";
        /*
		AudioSource[] audios = GetComponents<AudioSource> ();
		appleCollect = audios [0];
        */

		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);
	}

    void Update()
    {
        Timer();
    }

    void Timer()
    {
        timeLeft -= Time.deltaTime;
        //Debug.Log(timeLeft);
        timeText.text = ("Time: " + Mathf.FloorToInt(timeLeft));
        if (timeLeft <= 0)
        {
            GameOver();
        }
    }

	void GameOver()
	{

	}

    void Win()
    {

    }
}
