using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AntwortAnzeigen : MonoBehaviour
{
    public GameObject activeBlock;
    public KartenZiehen skript;
    public Image rend;
    void Start()
    {
        skript = GetComponent<KartenZiehen>();
    }

    int[] loesungsarray = new int [] {1, 2, 3, 1};
    string kartenarray;
    

    public string KartenarrayBestimmen(){

        if(activeBlock.tag == "gruen"){
            kartenarray = "GrueneAntworten";}
            else if(activeBlock.tag == "blau"){
                kartenarray = "BlaueAntworten";}
                else if(activeBlock.tag == "rot"){
                    kartenarray = "RoteAntworten";}
        else{kartenarray = "SchwarzeAntworten";}

        return kartenarray;
    }

    public void ButtonOben() {
        
        string bestimmtesKartenarray = KartenarrayBestimmen();

        int randomZahl = skript.randomFrage+1;

        if (loesungsarray[skript.randomFrage] == 1){
            rend.gameObject.SetActive(true);
        rend.GetComponent<Image>().sprite = Resources.Load<Sprite>("Karten/"+bestimmtesKartenarray+"/"+randomZahl+".1");
        }
        else{rend.gameObject.SetActive(true);
        rend.GetComponent<Image>().sprite = Resources.Load<Sprite>("Karten/"+bestimmtesKartenarray+"/"+randomZahl+".2");}
    }

    public void ButtonMitte() {
         string bestimmtesKartenarray = KartenarrayBestimmen();

        int randomZahl = skript.randomFrage+1;

        if (loesungsarray[skript.randomFrage] == 2){
            rend.gameObject.SetActive(true);
        rend.GetComponent<Image>().sprite = Resources.Load<Sprite>("Karten/"+bestimmtesKartenarray+"/"+randomZahl+".1");
        }
        else{rend.gameObject.SetActive(true);
        rend.GetComponent<Image>().sprite = Resources.Load<Sprite>("Karten/"+bestimmtesKartenarray+"/"+randomZahl+".2");}
    }

    public void ButtonUnten() {
         string bestimmtesKartenarray = KartenarrayBestimmen();

        int randomZahl = skript.randomFrage+1;

        if (loesungsarray[skript.randomFrage] == 3){
            rend.gameObject.SetActive(true);
        rend.GetComponent<Image>().sprite = Resources.Load<Sprite>("Karten/"+bestimmtesKartenarray+"/"+randomZahl+".1");
        }
        else{rend.gameObject.SetActive(true);
        rend.GetComponent<Image>().sprite = Resources.Load<Sprite>("Karten/"+bestimmtesKartenarray+"/"+randomZahl+".2");}
    }
}
