using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public int ForwardForce = 500;
    public int SidewaysForce = 300;
    public int ForwardBackwards = 150;

    public Vector3 startPos;


    // Start is called before the first frame update
    void Start()
    {
        rb.useGravity = true;
        rb.AddForce(0,0,0);
        transform.position = startPos;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);


        if (Input.GetKey("a"))
        {
            rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, ForwardBackwards * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -ForwardBackwards * Time.deltaTime);
        }


        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame(); // atrod gamemanager, aktivizē EndGame
        }



    }
}
