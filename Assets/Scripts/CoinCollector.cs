using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    [SerializeField] int coinValue = 25; // Her coin kaç puan ekler
    [SerializeField] AudioClip coinSound; // Coin sesi
    private int currentScore = 0; // Toplam skor

    private AudioSource audioSource;

    private void Start()
    {
        // Oyuncu nesnesinde bir AudioSource bileşeni olup olmadığını kontrol et
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            // Yoksa, otomatik olarak bir tane ekle
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    public int GetScore()
    {
        return currentScore;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin")) // Eğer coin'e çarptıysa
        {
            currentScore += coinValue; // Skoru artır

            // Ses efektini çal
            if (coinSound != null)
            {
                audioSource.PlayOneShot(coinSound);
            }

            Destroy(other.gameObject); // Coin'i yok et
        }
    }
}
