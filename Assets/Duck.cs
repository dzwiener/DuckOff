using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Duck : Player
{
    [SerializeField] Vector3 moveVec;
    [SerializeField] float moveSpeed;
    Vector2 inputVec;
    bool interactPressed;

    // Start is called before the first frame update
    void Start()
    {
      base.Start();
    }

    // Update is called once per frame
    void Update()
    {

      finalMove = moveSpeed * Time.deltaTime * moveVec;
      transform.position = new Vector3
        (
            Mathf.Clamp(transform.position.x + finalMove.x, -6.83f, 6.83f),
            Mathf.Clamp(transform.position.y + finalMove.y, -3.5f, 3.5f),
            0.0f
        );
        setHoldPosition(moveVec);
    }


    void OnMove(InputValue input)
    {
      inputVec = input.Get<Vector2>();
      moveVec = new Vector3(inputVec.x, inputVec.y, 0);
    }

    void OnInteract(InputValue input)
    {
      interactPressed = input.isPressed;

      if(interactPressed){
        Debug.Log("Duck Interacted");
      }
    }
}
