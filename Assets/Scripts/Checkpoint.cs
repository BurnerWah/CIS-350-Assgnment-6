/*
 * Jaden Pleasants
 * Assignment 6
 * Base class for checkpoints
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {
    public Checkpoint nextCheckpoint;

    public virtual void HandleCheckpoint() {
        Debug.Log("Checkpoint reached");
        nextCheckpoint.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }

    protected virtual void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            Debug.Log("Checkpoint reached");
            nextCheckpoint.gameObject.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
