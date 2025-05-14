using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController3D : MonoBehaviour
{
    private Rigidbody myRB;
    private bool isGrounded;
    [SerializeField]private Vector2 direction;
    [SerializeField]private float speed;
    [SerializeField]private float jumpForce;

    private void Start()
    {
        myRB = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 mov = new Vector3(direction.x, myRB.linearVelocity.y, direction.y);
        myRB.linearVelocity = mov * speed;
    }
    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
        Debug.Log("Puerdes saltar");
    }

    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
        Debug.Log("No puedes saltar");
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
    }
    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed && isGrounded)
        {
            myRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
    public void ApllyPhysics(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            string pressedKey = context.control.name;

            if (pressedKey == "q")
            {
                Debug.Log("Q");
            }
            else if (pressedKey == "e")
            {
                Debug.Log("E");
            }
        }
    }
}
