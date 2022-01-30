//The bakery assigns challenges to the players.
//It needs a steady supply of bread each round or else both players will be unemployed
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bakery : MonoBehaviour
{
    public float bread;
    public string challenge;

    void Start(){
      bread = 5f;
    }




    public void acceptBread(float quantity, float quality = 1f){
        bread = bread + (quantity * quality);
    }

    public void endRound(){
      bread = bread - 0.5f;
      Debug.Log("Bakery bread Remaining: " + bread);
    }

}
