using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {
    
    public GameObject startingTile; 
    public GameObject currentTile;
    public GameObject checkTile;
    public GameObject spielerObject;
    public Tile tileArray;
    public Tile newTile;
    public Image wuerfel;
    //public int gewuenschtesFeld;
    public int action1;
    public SpielerCount spielerCount_skript;

    // Zu Beginn des Spiels wird einmalig der currentTile gleich der Startposition gesetzt
    void Awake() {
       currentTile = startingTile;
    }

    void Start() {
        tileArray = startingTile.GetComponent<Tile>();
    }

    public void MovePlayer(int moves){
        StartCoroutine(Move(moves));
    }

    public IEnumerator Move(int moves){

        // schleife wird gemäß der Würfelzahl durchlaufen 
        for (int i = moves; i > 0; i--) {
              
            tileArray.ColliderAn();
            // letzte gespeicherte Aktion wird gelöscht
            action1 = 0; 

            // Schleife wartet bis ein Click auf eins der möglichen Felder erfolgt
            while(action1 == 0) { 
                yield return new WaitForSeconds(1.0f);
                
                //für jedes mögliche Feld wird gecheckt, ob dieses ausgewählt wurde
                for (int j = 0; j < tileArray.NextTile.Length; j++) {

                    checkTile = tileArray.NextTile[j];
                    newTile = checkTile.GetComponent<Tile>();
                    
                    if (newTile.action == 1){
                        tileArray.ColliderAus();
                        newTile.action = 0;

                        currentTile = tileArray.NextTile[j];
                        tileArray = currentTile.GetComponent<Tile>();

                        spielerObject.transform.position = currentTile.gameObject.transform.position;
                        spielerObject.transform.position = new Vector3(spielerObject.transform.position.x, spielerObject.transform.position.y + 0.8f, spielerObject.transform.position.z);
                        action1 = 1;
                    }
                }
            }
        }
        StartCoroutine("WuerfelSchliessen");
        spielerCount_skript.NaechsterSpieler();

    }

    //0,9 Sekunden warten, bevor der Würfel deaktiviert wird
    private IEnumerator WuerfelSchliessen() {

        yield return new WaitForSeconds(0.9f);
        wuerfel.gameObject.SetActive(false);
    }
}
