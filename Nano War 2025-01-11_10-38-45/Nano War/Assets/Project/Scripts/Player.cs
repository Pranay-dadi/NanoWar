﻿using UnityEngine;

//To specify properties of player object.
namespace NanoWar {
    public class Player : Plane {
        [SerializeField] float maxFuel;
        [SerializeField] float fuelConsumptionRate;
        
        float fuel;
        
        void Start() => fuel = maxFuel;

        public float GetFuelNormalized() => fuel / maxFuel;
        
        void Update() {
            fuel -= fuelConsumptionRate * Time.deltaTime;
        }
        
        public void AddFuel(float amount) {
            fuel += amount;
            if (fuel > maxFuel) {
                fuel = maxFuel;
            }
        }

        public void OnCollisionWithHealthBoost(int healthAmount) {
            AddHealth(healthAmount); // Add health when colliding with a health boost item
        }


        protected override void Die() {
            // TODO: Implement VFX?  Freeze Controls?
        }
    }
}