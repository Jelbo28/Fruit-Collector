using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GM : MonoBehaviour 
{
    #region variables
    [SerializeField]
    float timeLeft;


    [SerializeField]
	Text timeText;
	[SerializeField]
	Text scoreText;
	[SerializeField]
	GameObject player;

    int score = 0;
	public static GM instance = null;

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

    public void Win()
    {
        Debug.Log("Win!");
        Time.timeScale = 0;
    }

    public void UpdateScore()
    {
        score++;
        scoreText.text = ("Score: " + score);
    }
}
