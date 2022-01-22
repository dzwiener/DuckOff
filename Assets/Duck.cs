using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : Player
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.W)){
        //move up
        //transform.position = transform.position + new Vector2(0,1);//TODO
        transform.position = transform.position + new Vector3(0,1,0);//TODO
      } else if (Input.GetKeyDown(KeyCode.S)){
        //move down
        // transform.position = transform.position + new Vector2(0,-1);
        transform.position = transform.position + new Vector3(0,-1,0);//TODO
      }
      if (Input.GetKeyDown(KeyCode.A)){
        //move left
        // transform.position = transform.position + new Vector2(-1,0);
        transform.position = transform.position + new Vector3(-1,0,0);//TODO
      } else if (Input.GetKeyDown(KeyCode.D)){
        //move right
        //transform.position = transform.position + new Vector2(1,0);
        transform.position = transform.position + new Vector3(1,0,0);//TODO
      }
    }

}
