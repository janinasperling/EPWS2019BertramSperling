using System.Collections;
using UnityEngine;

public class Karten : MonoBehaviour {
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
    private SpriteRenderer rend;

    private void Start () {

        // Assign Renderer component
        rend = GetComponent<SpriteRenderer>();

        // Karten aus dem Ordner in Array laden 
        grueneFragen = Resources.LoadAll<Sprite>("GrueneFragen/");
        grueneAntworten = Resources.LoadAll<Sprite>("GrueneAntworten/");
        blaueFragen = Resources.LoadAll<Sprite>("BlaueFragen/");
        blaueAntworten = Resources.LoadAll<Sprite>("BlaueAntworten/");
        roteFragen = Resources.LoadAll<Sprite>("RoteFragen/");
        roteAntworten = Resources.LoadAll<Sprite>("RoteAntworten/");
        schwarzeFragen = Resources.LoadAll<Sprite>("SchwarzeFragen/");
        schwarzeAntworten = Resources.LoadAll<Sprite>("SchwarzeAntworten/");
        ereigniskarten = Resources.LoadAll<Sprite>("Ereigniskarten/");
	}

    //Frage anzeigen
    private int FrageAnzeigen(Sprite[] kartenarray){

        int randomFrage = 0;

        // Random Zahl von der Kartenmenge generieren
        randomFrage = Random.Range(0, kartenarray.Length);

        // Set sprite to upper face of dice from array according to random value
        rend.sprite = kartenarray[randomFrage];

        return randomFrage;
    }

    // Bei Mausklick Antwort anzeigen
    private void OnMouseDown()
    {
        StartCoroutine("KarteDrehen");
    }

    private void KarteDrehen(Sprite[] kartenarray, int nummer)
    {
        rend.sprite = kartenarray[nummer];
    }
}