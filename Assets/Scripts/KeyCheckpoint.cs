/*
 * Jaden Pleasants
 * Assignment 6
 * Class for key checkpoints (All of these must be passed through by the player)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCheckpoint : Checkpoint {
    public KeyCheckpoint nextKeyCheckpoint;

    public bool activedCorrectly;

    public override void HandleCheckpoint() {
        base.HandleCheckpoint();
        nextKeyCheckpoint.gameObject.SetActive(true);
        nextKeyCheckpoint.activedCorrectly = true;
        activedCorrectly = false;
        gameObject.SetActive(false);
    }

    protected override void OnTriggerEnter(Collider other) {
        base.OnTriggerEnter(other);
        if (other.gameObject.CompareTag("Player")) {
            nextKeyCheckpoint.gameObject.SetActive(true);
            nextKeyCheckpoint.activedCorrectly = true;
            activedCorrectly = false;
            gameObject.SetActive(false);
        }
    }
}
