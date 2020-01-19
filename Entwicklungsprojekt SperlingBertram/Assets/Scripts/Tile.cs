using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Tile : MonoBehaviour {

    public GameObject[] NextTile;
    public Collider boxCollider;
    public int action;
    public PlayerMovement playerMovement_skript;
    public Material[] material;
    Renderer rend; 

    // Die Collider der angrenzenden Felder werden aktiviert und somit klickbar
    // Zum Highlighten der Felder wird ein anderes Material ausgewählt
    public void ColliderAn() {
        foreach(GameObject o in NextTile) {
            boxCollider = o.GetComponent<Collider>();
            boxCollider.enabled = true;
            rend = o.GetComponent<Renderer>();
            rend.material = o.GetComponent<Tile>().material[1];
        }
    }

    public void ColliderAus() {
        foreach(GameObject o in NextTile) {
            boxCollider = o.GetComponent<Collider>();
            boxCollider.enabled = false;
          rend = o.GetComponent<Renderer>();
          rend.material = o.GetComponent<Tile>().material[0];
        }
    }

    // Die Varibale action wird auf 1 gesetzt, sobald das Feld angeklickt wurde
    public void OnMouseDown() {
        action = 1;
    }
}
