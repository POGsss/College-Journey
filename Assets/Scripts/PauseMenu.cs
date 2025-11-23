using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseUI;
    public GameObject pauseButton;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseUI.SetActive(true);
            pauseButton.SetActive(false);
            Time.timeScale = 0;
        }
    }

    public void PauseButton()
    {
        pauseUI.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0;
    }

    public void ResumeButton()
    {
        pauseUI.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1;
    }

    public void RestartButton()
    {
        pauseUI.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenuButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("TitleScreen");
    }
}