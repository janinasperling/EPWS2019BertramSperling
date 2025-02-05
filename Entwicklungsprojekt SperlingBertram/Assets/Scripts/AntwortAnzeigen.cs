﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AntwortAnzeigen : MonoBehaviour {

    public KartenZiehen kartenZiehen_skript;
    public PlayerMovement playerMovement_skript;
    public SpielerCount spielerCount_skript;
    public SpielBeenden spielBeenden_skript;
    public Image rend;
    public Image wuerfel;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject buttonKarteVerlassen;
    public GameObject buttonGewinner;
    
    void Start(){
        kartenZiehen_skript = GetComponent<KartenZiehen>();
        playerMovement_skript = GetComponent<PlayerMovement>();
    }

    // gewünschtes Array wird als String gespeichert um den Pfad des Bildes später angeben zu können
    string kartenarray;
    int[] loesungsarray = new int [] {1, 2, 3, 1};
    
    public string KartenarrayBestimmen(){

        playerMovement_skript = GameObject.Find("Player"+spielerCount_skript.actualplayer).GetComponent<PlayerMovement>();

        // String für Karten abhängig von Tag des aktuellen Cubes bestimmen
        if(playerMovement_skript.currentTile.tag == "gruen"){
            kartenarray = "GrueneAntworten";}
            else if(playerMovement_skript.currentTile.tag == "blau"){
                kartenarray = "BlaueAntworten";}
                else if(playerMovement_skript.currentTile.tag == "rot"){
                    kartenarray = "RoteAntworten";}
        else{kartenarray = "SchwarzeAntworten";}

        return kartenarray;
    }

    public void ButtonOben() {

        bool gewonnen = false;
        string bestimmtesKartenarray = KartenarrayBestimmen();

        // zuvor bestimmte Nummer der Frage einbinden
        // +1 da Benennung der Karten bei 1 beginnt
        int randomZahl = kartenZiehen_skript.randomFrage+1;

        // Angeklickte Antwort auf Lösung überprüfen und zugehörige Antwort anzeigen
        // Bei richtiger Lösung wir der Würfel aktiviert
        if (loesungsarray[kartenZiehen_skript.randomFrage] == 1){
            rend.GetComponent<Image>().sprite = Resources.Load<Sprite>("Karten/"+bestimmtesKartenarray+"/"+randomZahl+".1");
            wuerfel.gameObject.SetActive(true);

            if(playerMovement_skript.currentTile == GameObject.Find("Cube - Visual (221)")){ gewonnen = true;}
        }

        else{rend.GetComponent<Image>().sprite = Resources.Load<Sprite>("Karten/"+bestimmtesKartenarray+"/"+randomZahl+".2");
            spielerCount_skript.NaechsterSpieler();}

        ButtonsDeaktivieren();
        buttonKarteVerlassen.gameObject.SetActive(true);

        if(gewonnen==true){
            buttonKarteVerlassen.gameObject.SetActive(false);
            spielBeenden_skript.Gewonnen();
        }
    }

    public void ButtonMitte() {

        bool gewonnen = false;
        string bestimmtesKartenarray = KartenarrayBestimmen();
        int randomZahl = kartenZiehen_skript.randomFrage+1;

        if (loesungsarray[kartenZiehen_skript.randomFrage] == 2){
                rend.GetComponent<Image>().sprite = Resources.Load<Sprite>("Karten/"+bestimmtesKartenarray+"/"+randomZahl+".1");
                wuerfel.gameObject.SetActive(true);

                if(playerMovement_skript.currentTile == GameObject.Find("Cube - Visual (221)")){ gewonnen = true;}
        }

        else{rend.GetComponent<Image>().sprite = Resources.Load<Sprite>("Karten/"+bestimmtesKartenarray+"/"+randomZahl+".2");
            spielerCount_skript.NaechsterSpieler();}

        ButtonsDeaktivieren();
        buttonKarteVerlassen.gameObject.SetActive(true);

        if(gewonnen==true){
            buttonKarteVerlassen.gameObject.SetActive(false);
            spielBeenden_skript.Gewonnen();
        }
    }

    public void ButtonUnten() {

        bool gewonnen = false;
        string bestimmtesKartenarray = KartenarrayBestimmen();
        int randomZahl = kartenZiehen_skript.randomFrage+1;

        if (loesungsarray[kartenZiehen_skript.randomFrage] == 3){
                rend.GetComponent<Image>().sprite = Resources.Load<Sprite>("Karten/"+bestimmtesKartenarray+"/"+randomZahl+".1");
                wuerfel.gameObject.SetActive(true);

                if(playerMovement_skript.currentTile == GameObject.Find("Cube - Visual (221)")){ gewonnen = true;}
        }

        else{rend.GetComponent<Image>().sprite = Resources.Load<Sprite>("Karten/"+bestimmtesKartenarray+"/"+randomZahl+".2");
            spielerCount_skript.NaechsterSpieler();}

        ButtonsDeaktivieren();
        buttonKarteVerlassen.gameObject.SetActive(true);

        if(gewonnen==true){
            buttonKarteVerlassen.gameObject.SetActive(false);
            spielBeenden_skript.Gewonnen();
        }
    }

    // Buttons für Antwortmöglichkeiten deaktivieren
    public void ButtonsDeaktivieren(){
        button1.gameObject.SetActive(false);
        button2.gameObject.SetActive(false);
        button3.gameObject.SetActive(false);
    }

    // Image deaktivieren
      public void KartenansichtVerlassen() {
        rend.gameObject.SetActive(false);
    }
}
