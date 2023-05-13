using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Rigidbody rb;
    public GameObject player;
    public GameObject seed;
    public GameObject bird;

    public float jumpHeight = 20;
    public float speed = 5;
    public float flyHeight = 10;

    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {

        if (bird.activeInHierarchy == true)
        {
            Fly();
        }






    }

    private void FixedUpdate()
    {
        if (seed.activeInHierarchy == true)
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

    private void Fly() 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * flyHeight;
        }
        
    }








}
