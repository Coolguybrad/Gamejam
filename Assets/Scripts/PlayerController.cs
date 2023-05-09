using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Rigidbody rb; 
    
    
    public float jumpHeight = 10;


    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        

        if (Input.GetKeyDown(KeyCode.DownArrow))//when down arrow is pressed calls down
        {
            Down();
        }

       



    }

    private void FixedUpdate()
    {


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
            rb.AddForce(Vector3.up*0);
        }

    }

    






}
