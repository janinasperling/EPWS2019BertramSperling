using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ereigniskarten : MonoBehaviour {

    public Image wuerfel;
    public Image rend;
    public GameObject button;
    public KartenZiehen kartenZiehen_skript;
    public SpielerCount spielerCount_skript;
    public PlayerMovement playerMovement_skript;
    public GameObject startingTile;
    public GameObject spielerObject;

    
    public void Ereignis(){

        rend.gameObject.SetActive(false);
        button.gameObject.SetActive(false);

        switch (kartenZiehen_skript.randomFrage){
            case 0: 
                wuerfel.gameObject.SetActive(true);
                break;
            case 1:
                    playerMovement_skript = GameObject.Find("Player"+spielerCount_skript.actualplayer).GetComponent<PlayerMovement>();
                    playerMovement_skript.MovePlayer(3);
                break;
            case 2:
            for(int i=1; i<= spielerCount_skript.spieler; i++){
                playerMovement_skript = GameObject.Find("Player"+i).GetComponent<PlayerMovement>();
                spielerObject = playerMovement_skript.spielerObject;
                startingTile = playerMovement_skript.startingTile;
                playerMovement_skript.currentTile = startingTile;
                playerMovement_skript.tileArray = startingTile.GetComponent<Tile>();
                spielerObject.transform.position = startingTile.gameObject.transform.position;
                spielerObject.transform.position = new Vector3(spielerObject.transform.position.x, spielerObject.transform.position.y + 0.8f, spielerObject.transform.position.z);
                }
                spielerCount_skript.NaechsterSpieler();
                break;
        }
    }
}
