using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuu : MonoBehaviour
{
    public bool isPaused; // Flag to track pause state
    public GameObject GamePausePanel;


    private void Start()
    {
        ResumeGame();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Toggle pause state on Escape key press
            isPaused = !isPaused;

            if (isPaused)
            {
                PauseGame();
            }
            else
            {
                ResumeGame();
            }
        }
    }

    public void PauseGame()
    {
        // Set Time.timeScale to 0 to pause gameplay
        Time.timeScale = 0;

        // Make PauseMenu panel visible (activate its gameObject)
        GamePausePanel.SetActive(true);
    }

    public void ResumeGame()
    {
        // Set Time.timeScale back to 1 to resume gameplay
        Time.timeScale = 1;

        // Hide PauseMenu panel (deactivate its gameObject)
        GamePausePanel.SetActive(false);
    }
}
