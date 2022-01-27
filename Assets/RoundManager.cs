using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundManager : MonoBehaviour
{
  public float roundTime;
  public bool isRound;
  Human human;
  Duck duck;
    // Start is called before the first frame update
    void Start()
    {
      roundTime = 30f;
    }

    // Update is called once per frame
    void Update()
    {
      if (isRound){
        roundTime -= Time.deltaTime;
      }
      if (roundTime <= 0){
        roundEnded();
      }

    }

    void roundEnded(){
      isRound = false;
      //pop up a notice
      //show the bread given to the bakery
      //if the bakery didn't get enough, game over and both players lose
      //show the bread each player has
      //if one of the players hit the goal, they win
      if (human.bread >= 100 && human.bread - duck.bread > 0){
        Debug.Log("Human gets to feed their family");
      } else if (duck.bread >= 100 && duck.bread - human.bread > 0){
        Debug.Log("Duck gets to survive the winter migration");
      } else if (duck.bread >=100 && duck.bread == human.bread){
        Debug.Log("Seize the means of production, we've done it!");
      } else if (bakery.bread < 0){
        Debug.Log("You're going to be sleeping in the streets");
      } else {
        Debug.Log("Another day of work coming up");
      }
    }
}
