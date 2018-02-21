using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverScoreDisplay : MonoBehaviour {
    Text text;
    int score;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        score = FindObjectOfType<ScoreAbsorber>().score;
        text.text = "You scored: " + score;
	}
}
