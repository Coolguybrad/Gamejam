using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController : MonoBehaviour
{
    // Start is called before the first frame update
    private CustomInput input = null;
    private Vector3 move = Vector3.zero;
    public Rigidbody rb;
    private float speed = 10f;
    public float jump = 1f;


    private void Awake()
    {
        input = new CustomInput();

    }

    private void OnEnable()
    {
        input.Enable();
        input.PlayerVert.Movement.performed += onMovement;
        input.PlayerVert.Movement.canceled += onMovementStopped;
    }

    private void FixedUpdate()
    {
        rb.velocity = move * speed;
        print(rb.velocity.y);
        if (rb.velocity.y == 0)
        {
            rb.AddForce(Vector3.up * jump, ForceMode.Impulse);
        }



    }

    private void OnDisable()
    {
        input.Disable();
        input.PlayerVert.Movement.performed -= onMovement;
        input.PlayerVert.Movement.canceled -= onMovementStopped;
    }

    private void onMovement(InputAction.CallbackContext v)
    {
        move = v.ReadValue<Vector3>();
    }

    private void onMovementStopped(InputAction.CallbackContext v)
    {
        move = Vector3.zero;
    }
}
