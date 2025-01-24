﻿using Eflatun.SceneReference;
using UnityEngine;

//Manages game play and interaction between different objects in the game.
namespace NanoWar {
    public class GameManager : MonoBehaviour {
        [SerializeField] SceneReference mainMenuScene;
        [SerializeField] GameObject gameOverUI;
        
        public static GameManager Instance { get; private set; }
        public Player Player => player;

        Player player;
        int score;
        float restartTimer = 3f;
        
        public bool IsGameOver() => player.GetHealthNormalized() <= 0 || player.GetFuelNormalized() <= 0;
        // TODO Add a next level instead of game over when boss dies

        void Awake() {
            Instance = this;
            player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        }

        void Update() {
            if (IsGameOver()) {
                restartTimer -= Time.deltaTime;

                if (gameOverUI.activeSelf == false) {
                    gameOverUI.SetActive(true);
                }
                    
                if (restartTimer <= 0) {
                    Loader.Load(mainMenuScene);
                }
            }
        }
        
        public void AddScore(int amount) => score += amount;
        public int GetScore() => score;
    }
}