using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpielBeenden : MonoBehaviour
{
    public Image rend;
    public GameObject buttonSpielVerlassen;
    public SpielerCount spielerCount_skript;

    public void Gewonnen(){
        rend.gameObject.SetActive(true);
        rend.GetComponent<Image>().sprite = Resources.Load<Sprite>("Karten/Gewonnen/"+spielerCount_skript.actualplayer);
        buttonSpielVerlassen.gameObject.SetActive(true);
    }

    public void ZurueckZumStart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
