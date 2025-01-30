using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] CoinCollector coinCollector; // CoinCollector referansı
    [SerializeField] TextMeshProUGUI scoreText;   // TextMeshPro referansı

    void Update()
    {
        scoreText.text = "Skor: " + coinCollector.GetScore();
    }
}