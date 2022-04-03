/*
 * Jaden Pleasants
 * Assignment 6
 * Demo super class for inheretance
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour, IDamageable {
    protected float speed;
    protected int health;

    [SerializeField] protected Weapon weapon;

    protected virtual void Awake() {
        weapon = gameObject.AddComponent<Weapon>();

        speed = 5f;
        health = 100;
    }

    protected abstract void Attack();
    public abstract void TakeDamage(int amount);
}
