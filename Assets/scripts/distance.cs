using UnityEngine;
using UnityEngine.UI;

public class distance : MonoBehaviour
{

    public Transform player; // ņem transform no player (player unity jāievelk kastītē)
    public Text Distance; // Text sadaļai

    void Update()
    {

        // float res = player.position.z;
        Distance.text = player.position.z.ToString("0");


    }
}
