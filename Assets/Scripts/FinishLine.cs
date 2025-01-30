using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float delayTime = 0.5f;
    [SerializeField] ParticleSystem finishEffect;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke(nameof(LoadNextScene), delayTime);
        }
    }

    void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        // Eğer "nextSceneIndex" build ayarları aralığındaysa:
        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            // Burada ister menüye dön, ister ilk levela dön vs.
            SceneManager.LoadScene("MainMenu"); 
        }
    }
}
