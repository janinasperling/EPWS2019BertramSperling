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
    //public Material[] material;
    //Renderer rend; 

    /*void Start(){
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }*/

    // Die Collider der angrenzenden Felder werden aktiviert und somit klickbar
    public void ColliderAn() {
        foreach(GameObject o in NextTile) {
            boxCollider = o.GetComponent<Collider>();
            boxCollider.enabled = true;
           // o.GetComponent<Renderer>().sharedMaterial = material[1];
        }
    }

    public void ColliderAus() {
        foreach(GameObject o in NextTile) {
            boxCollider = o.GetComponent<Collider>();
            boxCollider.enabled = false;
           // o.GetComponent<Renderer>().sharedMaterial = material[0];
        }
    }

    // Die Varibale action wird auf 1 gesetzt, sobald das Feld angeklickt wurde
    public void OnMouseDown() {
        action = 1;
    }
}
