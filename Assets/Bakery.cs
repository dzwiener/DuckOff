//The bakery assigns challenges to the players.
//It needs a steady supply of bread each round or else both players will be unemployed
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bakery : MonoBehaviour
{
    public float bread;
    public string challenge;
    public int challengeQuant;

    public void createRoundChallenge(){
      float choice = Mathf.Round(Random.Range(0,5));
      switch (choice){
        case 0:
          challenge = "white";//normal bread
          break;
        case 1:
          challenge = "wheat";//requires more flour
          break;
        case 2:
          challenge = "sourdough";//needs to sit after being mixed for the right amount of time
          break;
        case 3:
          challenge = "wonder";//needs more mixing
          break;
        case 4:
          challenge = "crusty";//needs to be baked longer, smaller window between perfect and burnt
          break;
        default:
          challenge = "white";
          break;
      }
    }

    public void acceptBread(float quantity, float quality = 1f, string type = "white"){
      if (type == challenge){
        bread = bread + (quantity * quality);
      } else {
        bread = bread + (quantity/2 * quality);
      }
    }

    public void endRound(){
      bread = bread - 5;
    }

}
