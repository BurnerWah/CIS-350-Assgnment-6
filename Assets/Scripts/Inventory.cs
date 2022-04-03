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

    // Start is called before the first frame update
    void Start() {
        item = new InventoryItem();
        inventory = new List<InventoryItem>();
    }

    // Update is called once per frame
    void Update() {

    }
}
