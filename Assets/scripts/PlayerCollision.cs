using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement; // PlayerMovement ir cita skripta nosaukums.


    void OnCollisionEnter(Collision collisionInfo) // aktivizējas uz collision (collisionInfo pārbauda ar ko notika collision)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("Hit");
            movement.enabled = false;


            FindObjectOfType<GameManager>().EndGame();


        }

        // Debug.Log(collisionInfo.collider.tag);
    }

}
