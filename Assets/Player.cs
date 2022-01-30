using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  public Vector3 holdPosition;
  public Vector3 oldHoldPosition;
  public float bread;


  //   // Start is called before the first frame update
    public void Start()
    {
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

  //   // Update is called once per frame
    // void Update()
    // {
    // }

}
