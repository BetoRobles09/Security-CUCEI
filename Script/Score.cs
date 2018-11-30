using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public Text txt;
    public int score;
	// Use this for initialization
	void Start () {
		
	}

    void Update () {
        txt.text = "Score: " + score;
        if (score == 100)
        {
            txt.text = "Ganaste!";
        }
        if (Input.GetButtonDown("Fire2"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void updateScore(int deltaScore)
    {
        score += deltaScore;
        
    }
}
