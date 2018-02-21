using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
      
    }
    public void LoadNextScene()
    {
        
           int currentIndex = SceneManager.GetActiveScene().buildIndex;
           SceneManager.LoadScene(currentIndex + 1);
    }
    public void LoadPreviousScene()
    {

        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentIndex - 1);
    }
}
