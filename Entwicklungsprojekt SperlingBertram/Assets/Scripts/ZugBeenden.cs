using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZugBeenden : MonoBehaviour
{
    public int actualplayer=1;
    
    public void OnMouseDown(){
        if(actualplayer ==2){
            actualplayer =1;
        }
        else{ actualplayer++;}
       } 
       
    
}
    
    
