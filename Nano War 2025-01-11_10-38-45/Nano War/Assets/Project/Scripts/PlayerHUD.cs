﻿using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace NanoWar {
    public class PlayerHUD : MonoBehaviour {
        [SerializeField] Image healthBar;
        [SerializeField] Image fuelBar;
        [SerializeField] TextMeshProUGUI scoreText;
        [SerializeField] TextMeshProUGUI timeText;
        [SerializeField] TextMeshProUGUI healthText; // New: Text to display exact health

        private float startTime;

        void Start() {
            startTime = Time.time;
        }

        void Update() {
            Player player = GameManager.Instance.Player;

            healthBar.fillAmount = player.GetHealthNormalized();
            fuelBar.fillAmount = player.GetFuelNormalized();
            scoreText.text = $"Score: {GameManager.Instance.GetScore()}";
            healthText.text = $"Health: {player.GetHealthNormalized() * 100:F0}"; // Show health as a percentage

            // Calculate elapsed time
            float elapsedTime = Time.time - startTime;

            // Convert seconds to hours, minutes, and seconds
            TimeSpan timeSpan = TimeSpan.FromSeconds(elapsedTime);
            string timeString = string.Format("{0:D2}h:{1:D2}m:{2:D2}s",
                                              timeSpan.Hours,
                                              timeSpan.Minutes,
                                              timeSpan.Seconds);

            // Display time in the HUD
            timeText.text = $"Time: {timeString}";
        }
    }
}
