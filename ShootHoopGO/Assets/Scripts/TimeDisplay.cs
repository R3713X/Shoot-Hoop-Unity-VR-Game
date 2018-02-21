using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour {
    Text text;
    int timeLeft;
    // Use this for initialization
    void Start () {
        text = GetComponent<Text>();
        
    }
	
	// Update is called once per frame
	void Update () {
        timeLeft = (int) FindObjectOfType<GameTimer>().timeTillNextLevel;
        text.text = "Time:"+ timeLeft;
	}
}
