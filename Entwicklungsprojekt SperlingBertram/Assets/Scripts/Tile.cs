using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Tile : MonoBehaviour
{

    public GameObject[] NextTile;
    public Collider boxCollider;
    public string objektname;
    public int action;
    public PlayerMovement playerMovement_skript;
    //public GameObject Tile;

    public void ColliderAn() {
        foreach(GameObject o in NextTile) {
            boxCollider = o.GetComponent<Collider>();
            boxCollider.enabled = true;

        }
    }

    public void ColliderAus() {
        foreach(GameObject o in NextTile) {
            boxCollider = o.GetComponent<Collider>();
            boxCollider.enabled = false;

        }
    }

    public int OnMouseDown() {
        action = 1;
        return action;
    }
}
