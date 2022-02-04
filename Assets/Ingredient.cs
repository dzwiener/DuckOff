using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient : MonoBehaviour
{
    public int quality;
    public bool isReady;
    public bool isHeld;
    public Player holder;
    public string name;

    public void pickup(Player player){
      isHeld = true;
      holder = player;
    }

    public void drop(){
      isHeld = false;
      holder = null;
    }

    public void follow(){
      transform.position = holder.getHoldPosition();
    }

    // Update is called once per frame
    public void Update()
    {
      if (isHeld){
        follow();
      }

    }

    public string getName()
    {
      if(name != null){
        return name;
      } else {
        Debug.Log("Name has not been assigned for an object");
        return "";
      }
    }
}
