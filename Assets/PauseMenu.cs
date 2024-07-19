using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public bool isPaused; // Flag to track pause state

    void Update()
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

    void PauseGame()
    {
        // Set Time.timeScale to 0 to pause gameplay
        Time.timeScale = 0;

        // Make PauseMenu panel visible (activate its gameObject)
        gameObject.SetActive(true);
    }

    void ResumeGame()
    {
        // Set Time.timeScale back to 1 to resume gameplay
        Time.timeScale = 1;

        // Hide PauseMenu panel (deactivate its gameObject)
        gameObject.SetActive(false);
    }
}
