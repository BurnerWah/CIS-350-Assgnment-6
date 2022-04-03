/*
 * Jaden Pleasants
 * Assignment 6
 * Demo super class for inheretance
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour {
    protected float speed;
    protected int health;

    protected virtual void Awake() {
        speed = 5f;
        health = 100;
    }

    protected abstract void Attack();
}
