using System.Collections;
using UnityEngine;

public class GrueneKarten : MonoBehaviour{

    //ArrayList für die Spielkarten
    private Sprite[] grueneFragen;
    private Sprite[] grueneAntworten;
    private SpriteRenderer rend;

    public KartenZiehen kartenZiehen_script;

     private void Start (){

        // Assign Renderer component
        rend = GetComponent<SpriteRenderer>();

        // Karten aus dem Ordner in Array laden 
        grueneFragen = Resources.LoadAll<Sprite>("Karten/GrueneFragen/");
        grueneAntworten = Resources.LoadAll<Sprite>("Karten/GrueneAntworten/");
     }

     // Frage bei Mausklick anzeigen
    private void OnMouseDown(){

        StartCoroutine("FrageZeigen");
    }

    public int FrageZeigen(){
        int randomFrage = 0;

        // Random Zahl von der Kartenmenge generieren
        randomFrage = Random.Range(0, grueneFragen.Length);

        // Set sprite to upper face of dice from array according to random value
        rend.sprite = grueneFragen[randomFrage];

        return randomFrage;
    }

    //public void debugGezogeneKarte(){
      //  kartenZiehen_script.grueneAntwort[kartenZiehen_script.randomFrage];
        //kartenZiehen_script.ButtonClicked();
    //}
}
