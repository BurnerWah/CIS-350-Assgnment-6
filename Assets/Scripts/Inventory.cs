/*
 * Jaden Pleasants
 * Assignment 6
 * Small demo class for SerlailzeField
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {
    [SerializeField] private InventoryItem item;
    [SerializeField] private List<InventoryItem> inventory;

    void Start() {
        item = new InventoryItem();
        inventory = new List<InventoryItem>();
    }
}
