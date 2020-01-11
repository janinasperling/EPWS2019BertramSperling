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
        //Debug.Log(spieler);
        for(int i=4; i>spieler; i--){
            //Debug.Log(i);
                //Debug.Log(player);
              player = GameObject.Find("Player"+i);
              //Debug.Log(player.name);
              player.SetActive(false);
        }
    }
    
    public void NaechsterSpieler(){
        if(actualplayer != spieler){
            actualplayer++;
        }
        else{actualplayer = 1;}
        Debug.Log(actualplayer);
       } 
}
    
    
