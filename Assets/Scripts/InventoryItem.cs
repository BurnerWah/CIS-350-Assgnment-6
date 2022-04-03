/*
 * Jaden Pleasants
 * Assignment 6
 * Demo class that is serializable but doesn't extend MonoBehaviour
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InventoryItem {
    public int id;
    public string name;
}
