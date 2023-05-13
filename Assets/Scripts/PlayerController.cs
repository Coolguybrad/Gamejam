using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Rigidbody rb;
    public GameObject seed;
    public GameObject bird;

    public float jumpForce = 5f;
    public float jumpHeight = 20;
    public float speed = 5;

    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {


        if (bird.active)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity = Vector3.up * jumpForce;
            }
        }





    }

    private void FixedUpdate()
    {

        if (seed.active)
        {
            Jump();

            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(Vector3.left * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(Vector3.right * speed * Time.deltaTime);
            }
        }


    }

    private void Down()
    {
        rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse); //puts a downward force on the player to move them down quicker
    }

    private void Jump()
    {
        if (rb.velocity.y == 0f)//prevents player from jumping while in the air
        {

            rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);//puts an upward force on the player to make them jump

        }

    }








}
