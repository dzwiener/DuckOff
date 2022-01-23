using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Human : MonoBehaviour
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
      transform.position += moveSpeed * Time.deltaTime * moveVec;
    }

    void OnMove(InputValue input)
    {
      Vector2 inputVec = input.Get<Vector2>();
      moveVec = new Vector3(inputVec.x, inputVec.y, 0);
    }

}
