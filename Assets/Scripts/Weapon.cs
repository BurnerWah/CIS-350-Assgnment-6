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

    public void Recharge() {
        Debug.Log("Recharging Weapon!");
    }
}
