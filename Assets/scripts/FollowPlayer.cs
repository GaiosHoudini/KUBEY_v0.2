using UnityEngine;

public class FollowPlayer : MonoBehaviour
{


    public Transform player; // publiski, Transform sadaļa refferojas ar vārdu player, var piekļūt no player.position un citi.
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset; //transform (no objekta uz kura ir script(kamera)) = player position no player
    }
}
