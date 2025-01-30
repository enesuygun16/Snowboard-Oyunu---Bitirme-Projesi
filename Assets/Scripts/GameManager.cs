using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool isPaused = false; // Oyunun duraklatılıp duraklatılmadığını takip ediyor

    void Update()
    {
        // ESC tuşu ile menüye dön
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }

        // P tuşu ile oyunu duraklat / devam ettir
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0f;   // Zamanı durdurur, oyun duraklar
        isPaused = true;
    }

    void ResumeGame()
    {
        Time.timeScale = 1f;   // Zamanı normale çeker, oyun devam eder
        isPaused = false;
    }
}

