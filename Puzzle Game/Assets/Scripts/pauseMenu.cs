using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    // Variable created to see if the game is in apaused state
    public static bool GameIsPaused = false;

    //GameObject is made a variable becuase we will need to turn on and off the game object
    public GameObject pauseMenuUI;
    public GameObject scoreUI;
    public GameObject player;
    public GameObject camera;
    
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }

        }
        
    }

    // Disables the pause canvas, and sets true to the score canvas, and resumes the game using Time.timeScale
    public void Resume()
    {

        pauseMenuUI.SetActive(false);
        scoreUI.SetActive(true);
        player.GetComponent<PlayerMovement>().enabled = true;
        camera.GetComponent<cameraMovement>().enabled = true;

        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    //Sets active the pause canvas, sets false the score canvas, and pauses the game by making time scale to 0f
    void Pause()
    {
        scoreUI.SetActive(false);
        pauseMenuUI.SetActive(true);
        
        player.GetComponent<PlayerMovement>().enabled = false;
        camera.GetComponent<cameraMovement>().enabled = false;
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Debug.Log("Loading Menu.......");
    }

    //Restarts the level when clicked and calls resume
    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
        Resume();
    }
}
