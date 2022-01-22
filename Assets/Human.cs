using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : Player
{
    Duck duck;
    // Start is called before the first frame update
    void Start()
    {
      var duckObject = GameObject.Find("DUCK");
      duck = duckObject.GetComponent<Duck>();
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.UpArrow)){
        //move up
        transform.position = transform.position + new Vector3(0,1,0);
      } else if (Input.GetKeyDown(KeyCode.DownArrow)){
        //move down
        transform.position = transform.position + new Vector3(0,-1,0);
      }
      if (Input.GetKeyDown(KeyCode.LeftArrow)){
        //move left
        transform.position = transform.position + new Vector3(-1,0,0);
      } else if (Input.GetKeyDown(KeyCode.RightArrow)){
        //move right
        transform.position = transform.position + new Vector3(1,0,0);
      }
      if (touching(duck.getPosition())){
        bounce(duck.getPosition());
      }
    }

}
