using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    
    public GameObject startingTile; 
    public GameObject currentTile;
    public GameObject spielerObject;
    public Tile tileArray;
    public Image wuerfel;

    // Zu Beginn des Spiels wird einmalig der currentTile gleich der Startposition gesetzt
    void Awake() {
       currentTile = startingTile;
    }

    void Start() {
        tileArray = startingTile.GetComponent<Tile>();
    }

    public void MovePlayer(int moves){
           
        // currentTile gemäß der Würfelanzahl verändern
        while(moves > 0){
            if(tileArray.NextTile.Length > 1){
                //Funktion zur Auswahl der Route muss noch eingefügt werden
            }
            else {currentTile = tileArray.NextTile[0];
            tileArray = currentTile.GetComponent<Tile>();
            }
            moves--;
        }
        // aktuelle Position des Spielers auf Position des neuen Cubes setzen
        spielerObject.transform.position = currentTile.gameObject.transform.position;
        spielerObject.transform.position = new Vector3(spielerObject.transform.position.x, spielerObject.transform.position.y + 0.8f, spielerObject.transform.position.z);
        
        StartCoroutine("WuerfelSchliessen");
    }

    //0,9 Sekunden warten, bevor der Würfel deaktiviert wird
    private IEnumerator WuerfelSchliessen() {

        yield return new WaitForSeconds(0.9f);
        wuerfel.gameObject.SetActive(false);
    }
}
