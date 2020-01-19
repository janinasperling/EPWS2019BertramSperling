using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpielerCount : MonoBehaviour {
    public int actualplayer=1;
    public int spieler;   
    public GameObject player; 

    void Awake(){
        spieler = PlayerPrefs.GetInt("spieleranzahl");

        for(int i=4; i>spieler; i--){
              player = GameObject.Find("Player"+i);
              player.SetActive(false);
        }
    }
    
    public void NaechsterSpieler(){
        if(actualplayer != spieler){
            actualplayer++;
        }
        else{actualplayer = 1;}
       } 
}
    
    
