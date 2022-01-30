using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  public Vector3 holdPosition;
  public Vector3 oldHoldPosition;
  public float wheat;
  public float flour;
  public float water;
  public float dough;
  public float bread;

  //   // Start is called before the first frame update
    public void Start()
    {
      wheat = 0f;
      flour = 0f;
      water = 0f;
      dough = 0f;
      bread = 0f;
      oldHoldPosition = new Vector3(0,-1.2f,0);
    }

    public Vector3 getHoldPosition(){
      return holdPosition;
    }

    public void setHoldPosition(Vector3 moveVec){
      if (moveVec.x == 0 && moveVec.y == 0){
        holdPosition = oldHoldPosition;
      } else {
        holdPosition = transform.position + (moveVec * 1.2f);
        oldHoldPosition = holdPosition;
      //  Debug.Log(holdPosition);
      }
    }

    public void pickupWater(){
      water = water + 1f;
    }

    public string createFlour(){
      if (wheat > 0f){
        wheat = wheat - 2f;
        flour = flour + 1f;
        return "Created flour";
      } else {
        return "Need Wheat";
      }
    }

    public string createDough(){
      if(flour >= 2f && water > 0f){
        flour = flour - 2f;
        water = water - 1f;
        dough = dough + 1f;
        return "Created Dough";
      } else {
        return "Need 2 Flour and 1 Water";
      }
    }

    public string createBread(){
      if(dough > 0){
        dough = dough - 1;
        bread = bread + 1;
        return "Created Bread";
      } else {
        return "Need Dough";
      }
    }

    public string generateScoreStr()
    {
      string output = "";
      output += "Wheat: " + wheat + "\n";
      output += "Flour: " + flour + "\n";
      output += "Water: " + water + "\n";
      output += "Dough: " + dough + "\n";
      output += "Bread: " + bread + "\n";
      return output;
    }

  //   // Update is called once per frame
    // void Update()
    // {
    // }

}
