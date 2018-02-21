using UnityEngine;
using System.Collections;

public class ScoreAbsorber : MonoBehaviour {
    public int score;
    // Use this for initialization
    void Start () {
        ScoreKeeper oldScoreKeeper = FindObjectOfType<ScoreKeeper>();
        if (oldScoreKeeper) {
            score = oldScoreKeeper.score;
            Destroy(oldScoreKeeper.gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
