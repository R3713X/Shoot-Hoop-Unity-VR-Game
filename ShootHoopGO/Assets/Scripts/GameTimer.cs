using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour {
    public float timeTillNextLevel=20.0f;
	// Use this for initialization
	void Start () {
        
        
    }
	
	// Update is called once per frame
	void Update () {
        
       
            timeTillNextLevel -= Time.deltaTime;
            
            if (timeTillNextLevel <= 0)
            {
           
                LoadNextScene();
            }
    }


    public void LoadNextScene() {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentIndex + 1);
    }
}
