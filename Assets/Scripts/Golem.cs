/*
 * Jaden Pleasants
 * Assignment 6
 * Demo child class for inheretance
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem : Enemy {
    protected int damage;

    protected override void Attack() {
        Debug.Log("Golem attacks");
    }

    protected override void Awake() {
        base.Awake();
        health = 120;
    }

    public override void TakeDamage(int amount) {
        throw new System.NotImplementedException();
    }
}
