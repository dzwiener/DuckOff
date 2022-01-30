using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundManager : MonoBehaviour
{
  public float roundTime;
  Human human;
  Duck duck;
  Bakery bakery;

    // Start is called before the first frame update
    void Start()
    {
      bakery = GetComponentsInChildren<Bakery>()[0];
      human = GetComponentsInChildren<Human>()[0];
      duck = GetComponentsInChildren<Duck>()[0];
      newRound();
    }

    // Update is called once per frame
    void Update()
    {
      roundTime -= Time.deltaTime;
      if (roundTime <= 0){
        bakery.endRound();
        roundEnded();
      }

    }

    void newRound(){
      roundTime = 30f;
      //other stuff?
    }

    void roundEnded(){
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
        Debug.Log("You're going to be sleeping in the streets, the bakery is out of business you dingus");
      } else {
        Debug.Log("Another day of work coming up");
        newRound();
      }
    }
}
