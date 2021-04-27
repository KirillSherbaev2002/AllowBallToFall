using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour
{
    public Player player;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            player = FindObjectOfType<Player>();
            player.Touched();
            print("Done");
        }
    }
}
