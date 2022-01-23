using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  // const float touchingDistance = 0.5f;
  // int bread;
  //   // Start is called before the first frame update
    void Start()
    {

    }
  //
  //   // Update is called once per frame
    void Update()
    {
    }

  //   //after a collision, bounce away from the collision object but with some randomness
  //   public void bounce(Vector3 position){
  //     float x = 0.0f;
  //     float y = 0.0f;
  //     if (transform.position.x - position.x > 2){
  //       x = Random.Range(1, 3);
  //     } else if (transform.position.x - position.x < -2){
  //       x = Random.Range(-3, -1);
  //     } else {
  //       x = Random.Range(-1,1);
  //     }
  //     if (transform.position.y - position.y > 2){
  //       y = Random.Range(1, 3);
  //     } else if (transform.position.y - position.y < -2){
  //       y = Random.Range(-3, -1);
  //     } else {
  //       y = Random.Range(-1,1);
  //     }
  //     transform.position = transform.position + new Vector3(x, y, 0);
  //   }
  //
  //   public Vector3 getPosition(){
  //     return transform.position;
  //   }
  //
  //   public bool touching(Vector3 position){
  //     if (Mathf.Abs(transform.position.x - position.x) < touchingDistance && Mathf.Abs(transform.position.y - position.y) < touchingDistance){
  //       return true;
  //     } else {
  //       return false;
  //     }
  //   }
  //
  //   public void addBread(int quantity){
  //     bread = bread + quantity;
  //   }
}
