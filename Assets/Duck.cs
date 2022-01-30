using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Duck : Player
{
    [SerializeField] Vector3 moveVec;
    [SerializeField] float moveSpeed;
    [SerializeField] UIOverlay ScoreUI;

    void Start()
    {
      base.Start();
      ScoreUI.setDuckScore(generateScoreStr());
    }

    // Update is called once per frame
    void Update()
    {

      Vector3 finalMove = moveSpeed * Time.deltaTime * moveVec;
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
      Vector2 inputVec = input.Get<Vector2>();
      moveVec = new Vector3(inputVec.x, inputVec.y, 0);
    }

    void OnInteract(InputValue input)
    {
      bool interactPressed = input.isPressed;

      if(interactPressed){
        ScoreUI.setDuckScore(generateScoreStr());
        Debug.Log("Duck Interacted");
      }
    }

}
