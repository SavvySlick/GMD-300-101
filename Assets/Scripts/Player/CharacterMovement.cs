using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMovement : MonoBehaviour
{
    CharacterController controller;
    Vector3 spacialInputValue = Vector3.zero;


    // Start is called before the first frame update
    void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        controller.Move(spacialInputValue * Time.deltaTime);
    }

    void OnMove(InputValue input)
    {
        Vector2 inputValue = input.Get<Vector2>();
        spacialInputValue = new Vector3(inputValue.x, 0, inputValue.y);
    }
}
