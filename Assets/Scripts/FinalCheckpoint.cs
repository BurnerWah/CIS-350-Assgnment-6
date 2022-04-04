/*
 * Jade Pleasants
 * Assignment 6
 * Final checkpoint class - this handles the player winning, primarily
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalCheckpoint : KeyCheckpoint {
    public override void HandleCheckpoint() {
        base.HandleCheckpoint();
        GameManager.Instance.FinishLevel();
    }

    protected override void OnTriggerEnter(Collider other) {
        base.OnTriggerEnter(other);
        if (other.gameObject.CompareTag("Player")) {
            GameManager.Instance.FinishLevel();
        }
    }
}
