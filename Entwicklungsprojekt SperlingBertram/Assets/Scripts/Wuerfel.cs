using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Wuerfel : MonoBehaviour{

    // Array für die Seiten des Würfels
    private Sprite[] wuerfelSeiten;
    private SpriteRenderer rend;
    public int finaleSeite = 0;
    public PlayerMovement playerMovement_skript;

    private void Start (){

        rend = GetComponent<SpriteRenderer>();

        // Seiten aus dem Ordner in Array laden 
        wuerfelSeiten = Resources.LoadAll<Sprite>("WuerfelSeiten/");
	}
	
    // Würfelrollen bei Mausklick starten
    private void OnMouseDown(){
       StartCoroutine("Wuerfelrollen");
    }

    private IEnumerator Wuerfelrollen(){

        int randomWuerfelSeite = 0;

        // 20 Wiederholungen, bevor de finale Seite angezeigt wird
        for (int i = 0; i <= 20; i++)
        {
            // Random Zahl generieren
            randomWuerfelSeite = Random.Range(0, 3);

            // Sprite entsprechend der Würfelseite setzen
            rend.sprite = wuerfelSeiten[randomWuerfelSeite];

            // Pause vor der nächsten Iteration
            yield return new WaitForSeconds(0.05f);
        }

        // Finale Seite für Player Movement bestimmen
        finaleSeite = randomWuerfelSeite + 1;

        playerMovement_skript.MovePlayer(finaleSeite);
    }
}
