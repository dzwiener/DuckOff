using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient : MonoBehaviour
{
    public int quality;
    public bool isReady;
    public bool isHeld;
    public Player holder;

    public void pickup(Player player){
      isHeld = true;
      holder = player;
    }
}
