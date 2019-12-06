using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Wuerfel : MonoBehaviour{

    // Array für die Seiten des Würfels
    private Sprite[] wuerfelSeiten;

    // Reference to sprite renderer to change sprites
    private SpriteRenderer rend;

	private void Start (){

        // Assign Renderer component
        rend = GetComponent<SpriteRenderer>();

        // Seiten aus dem Odner in Array laden 
        wuerfelSeiten = Resources.LoadAll<Sprite>("WuerfelSeiten/");
	}
	
    // Würfelrollen bei Mausklick starten
    private void OnMouseDown(){

       StartCoroutine("Wuerfelrollen");
    }

    private IEnumerator Wuerfelrollen(){

        int randomWuerfelSeite = 0;

        int finaleSeite = 0;

        // 20 Wiederholungen, bevor de finale Seite angezeigt wird
        for (int i = 0; i <= 20; i++)
        {
            // Random Zahl von 0-2 generieren
            randomWuerfelSeite = Random.Range(0, 3);

            // Set sprite to upper face of dice from array according to random value
            rend.sprite = wuerfelSeiten[randomWuerfelSeite];

            // Pause vor der nächsten Iteration
            yield return new WaitForSeconds(0.05f);
        }

        // Finale Seite für Player Movement bestimmen
        finaleSeite = randomWuerfelSeite + 1;

        // Finale Zahl in Console ausgeben
        Debug.Log(finaleSeite);
    }

    public void ButtonClicked(){
         StartCoroutine("Wuerfelrollen");

    }
}
