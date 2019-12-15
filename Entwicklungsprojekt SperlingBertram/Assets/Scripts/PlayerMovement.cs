using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    
    public GameObject startingTile; 
    public GameObject currentTile;
    public GameObject spielerObject;
    public Tile tileArray;
    public Image wuerfel;


    void Awake() {
       currentTile = startingTile;
   }

   void Start() {
   tileArray = startingTile.GetComponent<Tile>();
   }


    public void MovePlayer(int moves){
           //currentTile = tileArray.NextTile[0];
        while(moves > 0){
            if(tileArray.NextTile.Length > 1){
                // parent object für buttons (pfeile) set object true
            }
            else {currentTile = tileArray.NextTile[0];
            tileArray = currentTile.GetComponent<Tile>();
            Debug.Log(moves);
            }
            moves--;
        }
        spielerObject.transform.position = currentTile.gameObject.transform.position;
        spielerObject.transform.position = new Vector3(spielerObject.transform.position.x, spielerObject.transform.position.y + 0.8f, spielerObject.transform.position.z);
        //new WaitForSeconds(0.9f);
        //wuerfel.gameObject.SetActive(false);
        StartCoroutine("WuerfelSchliessen");
    }

private IEnumerator WuerfelSchliessen() {
    Debug.Log("wuerfel");
    yield return new WaitForSeconds(0.9f);
    wuerfel.gameObject.SetActive(false);

}

}
