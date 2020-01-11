using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Startbildschirm : MonoBehaviour {
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public int spieler;

    public void EinSpieler(){

        spieler = 1;
        PlayerPrefs.SetInt("spieleranzahl", spieler);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }

    public void ZweiSpieler(){
        spieler = 2;
        PlayerPrefs.SetInt("spieleranzahl", spieler);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void DreiSpieler(){
        spieler = 3;
        PlayerPrefs.SetInt("spieleranzahl", spieler);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void VierSpieler(){
        spieler = 4;
        PlayerPrefs.SetInt("spieleranzahl", spieler);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
