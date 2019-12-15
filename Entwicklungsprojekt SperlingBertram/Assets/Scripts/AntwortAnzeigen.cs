using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AntwortAnzeigen : MonoBehaviour
{
    //public GameObject activeBlock;
    public KartenZiehen kartenZiehen_skript;
    public Image rend;
    public Image wuerfel;
    public PlayerMovement playerMovement_skript;
    
    void Start()
    {
        kartenZiehen_skript = GetComponent<KartenZiehen>();
        playerMovement_skript = GetComponent<PlayerMovement>();
    }

    int[] loesungsarray = new int [] {1, 2, 3, 1};
    string kartenarray;
    

    public string KartenarrayBestimmen(){

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
        
        string bestimmtesKartenarray = KartenarrayBestimmen();

        int randomZahl = kartenZiehen_skript.randomFrage+1;

        if (loesungsarray[kartenZiehen_skript.randomFrage] == 1){
            rend.gameObject.SetActive(true);
            rend.GetComponent<Image>().sprite = Resources.Load<Sprite>("Karten/"+bestimmtesKartenarray+"/"+randomZahl+".1");
            wuerfel.gameObject.SetActive(true);
        }
        else{rend.gameObject.SetActive(true);
            rend.GetComponent<Image>().sprite = Resources.Load<Sprite>("Karten/"+bestimmtesKartenarray+"/"+randomZahl+".2");}
    }

    public void ButtonMitte() {
         string bestimmtesKartenarray = KartenarrayBestimmen();

        int randomZahl = kartenZiehen_skript.randomFrage+1;

        if (loesungsarray[kartenZiehen_skript.randomFrage] == 2){
            rend.gameObject.SetActive(true);
            rend.GetComponent<Image>().sprite = Resources.Load<Sprite>("Karten/"+bestimmtesKartenarray+"/"+randomZahl+".1");
            wuerfel.gameObject.SetActive(true);
        }
        else{rend.gameObject.SetActive(true);
            rend.GetComponent<Image>().sprite = Resources.Load<Sprite>("Karten/"+bestimmtesKartenarray+"/"+randomZahl+".2");}
    }

    public void ButtonUnten() {
         string bestimmtesKartenarray = KartenarrayBestimmen();

        int randomZahl = kartenZiehen_skript.randomFrage+1;

        if (loesungsarray[kartenZiehen_skript.randomFrage] == 3){
            rend.gameObject.SetActive(true);
            rend.GetComponent<Image>().sprite = Resources.Load<Sprite>("Karten/"+bestimmtesKartenarray+"/"+randomZahl+".1");
            wuerfel.gameObject.SetActive(true);
        }
        else{rend.gameObject.SetActive(true);
            rend.GetComponent<Image>().sprite = Resources.Load<Sprite>("Karten/"+bestimmtesKartenarray+"/"+randomZahl+".2");}
    }

      public void KartenansichtVerlassen() {
        rend.gameObject.SetActive(false);
    }
}
