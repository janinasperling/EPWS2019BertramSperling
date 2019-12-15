using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KartenZiehen : MonoBehaviour{

    // Arrays für die Spielkarten anlegen
    private Sprite[] grueneFragen;
    private Sprite[] blaueFragen;
    private Sprite[] roteFragen;
    private Sprite[] schwarzeFragen;
    private Sprite[] ereigniskarten;
    public Image rend;
    public int randomFrage = 0;
    public PlayerMovement playerMovement_skript;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;

    private void Start (){

        // Karten aus dem Ordner in Arrays laden 
        grueneFragen = Resources.LoadAll<Sprite>("Karten/GrueneFragen/");
        blaueFragen = Resources.LoadAll<Sprite>("Karten/BlaueFragen/");
        roteFragen = Resources.LoadAll<Sprite>("Karten/RoteFragen/");
        schwarzeFragen = Resources.LoadAll<Sprite>("Karten/SchwarzeFragen/");
        ereigniskarten = Resources.LoadAll<Sprite>("Karten/Ereigniskarten/");
	}


    public void FrageAnzeigen(){

        Sprite[] kartenarray;

        // Kartenarray durch Tag des aktuellen Cubes bestimmen
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

        // Image aktivieren, Karte an Stelle von Objekt Image anzeigen
        rend.gameObject.SetActive(true);
        rend.GetComponent<Image>().sprite = kartenarray[randomFrage];

        // Buttons für Antwortmöglichkeiten aktivieren
        button1.gameObject.SetActive(true);
        button2.gameObject.SetActive(true);
        button3.gameObject.SetActive(true);
    }
}
