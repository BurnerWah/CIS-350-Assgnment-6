/*
 * Jaden Pleasants
 * Assignment 6
 * Demo for composition
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {
    public int damageBonus;

    public Enemy enemyHoldingWeapon;

    private void Awake() {
        enemyHoldingWeapon = gameObject.GetComponent<Enemy>();
    }

    protected void EnemyEatsWeapon(Enemy enemy) {
        Debug.Log("Enemy Eats Weapon");
    }

    public void Recharge() {
        Debug.Log("Recharging Weapon!");
    }
}
