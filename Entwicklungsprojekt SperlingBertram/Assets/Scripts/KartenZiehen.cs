using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KartenZiehen : MonoBehaviour{

    //ArrayList für die Spielkarten
    private Sprite[] grueneFragen;
    private Sprite[] grueneAntworten;
    private Sprite[] blaueFragen;
    private Sprite[] blaueAntworten;
    private Sprite[] roteFragen;
    private Sprite[] roteAntworten;
    private Sprite[] schwarzeFragen;
    private Sprite[] schwarzeAntworten;
    private Sprite[] ereigniskarten;
    public Image rend;

    public GameObject activeBlock;

    private void Start (){

        // Assign Renderer component
       // rend = GetComponent<SpriteRenderer>();

        // Karten aus dem Ordner in Array laden 
        grueneFragen = Resources.LoadAll<Sprite>("Karten/GrueneFragen/");
        grueneAntworten = Resources.LoadAll<Sprite>("Karten/GrueneAntworten/");
        blaueFragen = Resources.LoadAll<Sprite>("Karten/BlaueFragen/");
        blaueAntworten = Resources.LoadAll<Sprite>("Karten/BlaueAntworten/");
        roteFragen = Resources.LoadAll<Sprite>("Karten/RoteFragen/");
        roteAntworten = Resources.LoadAll<Sprite>("Karten/RoteAntworten/");
        schwarzeFragen = Resources.LoadAll<Sprite>("Karten/SchwarzeFragen/");
        schwarzeAntworten = Resources.LoadAll<Sprite>("Karten/SchwarzeAntworten/");
        ereigniskarten = Resources.LoadAll<Sprite>("Karten/Ereigniskarten/");
	}

    //Frage anzeigen
    public int FrageAnzeigen(/*Sprite[] kartenarray*/){

        Sprite[] kartenarray;

        if(activeBlock.tag == "gruen"){
            kartenarray = grueneFragen;
            Debug.Log("Grüne Karte");
        }else if(activeBlock.tag == "blau"){
            kartenarray = blaueFragen;
            Debug.Log("Grüne Karte");}
        
        else{kartenarray = ereigniskarten;}

        int randomFrage = 0;

        // Random Zahl von der Kartenmenge generieren
        randomFrage = Random.Range(0, kartenarray.Length);

        // Set sprite to upper face of dice from array according to random value
        rend.gameObject.SetActive(true);
        rend.GetComponent<Image>().sprite = kartenarray[randomFrage];
        

        return randomFrage;
    }

    // Bei Mausklick Antwort anzeigen
    private void OnMouseDown(){

        StartCoroutine("KarteDrehen");
    }

    private void KarteDrehen(Sprite[] kartenarray, int nummer){

        //rend.sprite = kartenarray[nummer];
    }

    public void ButtonClicked(){
        FrageAnzeigen();
    }
}
