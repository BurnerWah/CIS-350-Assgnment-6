/*
 * Jaden Pleasants
 * Assignment 6
 * Handles the player entering a checkpoint
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEnterCheckpoint : MonoBehaviour {
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Checkpoint")) {
            other.gameObject.TryGetComponent<Checkpoint>(out Checkpoint c);
            c?.HandleCheckpoint();
        }
    }
}
