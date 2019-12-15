using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KartenZiehen : MonoBehaviour{

    //ArrayList für die Spielkarten
    private Sprite[] grueneFragen;
    private Sprite[] blaueFragen;
    private Sprite[] roteFragen;
    private Sprite[] schwarzeFragen;
    private Sprite[] ereigniskarten;
    public Image rend;
    public int randomFrage = 0;

    public PlayerMovement playerMovement_skript;


    private void Start (){

        // Karten aus dem Ordner in Array laden 
        grueneFragen = Resources.LoadAll<Sprite>("Karten/GrueneFragen/");
        blaueFragen = Resources.LoadAll<Sprite>("Karten/BlaueFragen/");
        roteFragen = Resources.LoadAll<Sprite>("Karten/RoteFragen/");
        schwarzeFragen = Resources.LoadAll<Sprite>("Karten/SchwarzeFragen/");
        ereigniskarten = Resources.LoadAll<Sprite>("Karten/Ereigniskarten/");

	}


    //Frage anzeigen
    public void FrageAnzeigen(){

        Sprite[] kartenarray;

        //aktives Kartenarray bestimmen
        if(playerMovement_skript.currentTile.tag == "gruen"){
            kartenarray = grueneFragen;}
            else if(playerMovement_skript.currentTile.tag == "blau"){
                kartenarray = blaueFragen;}
                else if(playerMovement_skript.currentTile.tag == "rot"){
                    kartenarray = roteFragen;}
                    else if(playerMovement_skript.currentTile.tag == "schwarz"){
                        kartenarray = schwarzeFragen;}
        else{kartenarray = ereigniskarten;}

        // Random Zahl von der Kartenmenge generieren
        randomFrage = Random.Range(0, kartenarray.Length);

        //Karte an Stelle von Objekt Image anzeigen
        rend.gameObject.SetActive(true);
        rend.GetComponent<Image>().sprite = kartenarray[randomFrage];
    }
}
