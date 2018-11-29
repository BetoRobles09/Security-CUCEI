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
	
	// Update is called once per frame
	void Update () {
        txt.text = "Score: " + score;
        if (score == 70)
        {
            txt.text = "Ganaste!";
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
    }

    public void updateScore(int deltaScore)
    {
        score += deltaScore;
        
    }
}
