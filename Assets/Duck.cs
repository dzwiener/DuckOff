using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Duck : MonoBehaviour
{
    [SerializeField] Vector3 moveVec;
    [SerializeField] float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
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
    }

    void OnMove(InputValue input)
    {
      Vector2 inputVec = input.Get<Vector2>();
      moveVec = new Vector3(inputVec.x, inputVec.y, 0);
    }

}
