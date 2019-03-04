using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Check : MonoBehaviour {

    int score = 0;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
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

    void OnCollisionEnter(Collision collision)
    {
        score++;
        print("yse!" + score);
        LoadNextScene();

    }

}
