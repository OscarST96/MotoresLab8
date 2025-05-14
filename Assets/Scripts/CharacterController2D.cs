using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

/*CharacterController2D solo será una clase o componente para utilizar el
New Input System y hacer que nuestro jugador se mueva utilizando el
RigidBody2D*/
public class CharacterController2D : MonoBehaviour
{
    private Rigidbody2D myRBD2;
    private Vector2 direction;
    [SerializeField] private float velocity = 5f;

    private void Start()
    {
        myRBD2 = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        Vector2 mov = new Vector2 (direction.x, direction.y);
        myRBD2.linearVelocity = mov * velocity;
    }
    public void OnMovement(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
    }
}
