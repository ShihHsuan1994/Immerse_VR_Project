using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Manager : MonoBehaviour {

    // Use this for initialization
    void Start () {

        //Lock Cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
		
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

    /////////////////////////////////////////////////////////// Normal Scene
    public void Load_Wake_up()
    {
        SceneManager.LoadScene(0);
    }

    public void Load_Closet()
    {
        SceneManager.LoadScene(1);
    }

    public void Load_Table()
    {
        SceneManager.LoadScene(2);
    }

    public void Load_Fridge()
    {
        SceneManager.LoadScene(3);
    }

    public void Load_Door()
    {
        SceneManager.LoadScene(4);
    }

    /////////////////////////////////////////////////////////// Open

    public void Load_Closet_Open()
    {
        SceneManager.LoadScene(5);
    }

    public void Table_Open()
    {
        SceneManager.LoadScene(6);
    }

    public void Fridge_Open()
    {
        SceneManager.LoadScene(7);
    }

    public void Door_Open()
    {
        SceneManager.LoadScene(8);
    }

    ///////////////////////////////////////////////////////////
    //Sound Trigger

    public void Sound_On()
    {
        {
            AudioSource source = GetComponent<AudioSource>();
            source.Play();
        }
    }

    public void Sound_Off()
    {
        {
            AudioSource source = GetComponent<AudioSource>();
            source.Pause();
        }
    }
}
