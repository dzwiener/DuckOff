using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheat : Ingredient
{
    // Start is called before the first frame update
    void Start()
    {
      isHeld = false;
    }

    // Update is called once per frame
    void Update()
    {
      if (isHeld){
        Vector3 tempPosition = holder.transform.position;
        //point in the direction that the player moves
        tempPosition.x = holder.transform.position.x + (Mathf.Round(holder.getFinalMove().x)*2);
        tempPosition.y = holder.transform.position.y +(Mathf.Round(holder.getFinalMove().y)*2);
        //follow the holder
        Debug.Log("Move Vec total: " + (holder.getFinalMove()));//TODO: This is 0,0,0 for some reason?
      //transform.position = tempPosition;
        }

      }
}
