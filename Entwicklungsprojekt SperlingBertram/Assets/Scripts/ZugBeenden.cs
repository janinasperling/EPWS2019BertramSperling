using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZugBeenden : MonoBehaviour {
    public int actualplayer=1;
    public int spieler = 2;
    
    public void OnMouseDown(){
        if(actualplayer != spieler){
            actualplayer++;
        }
        else{actualplayer = 1;}
        Debug.Log(actualplayer);
       } 
}
    
    
