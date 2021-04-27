using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collapsed : MonoBehaviour
{
    public Player player;
    public GameObject Platform;
    public void Awake()
    {
        player = FindObjectOfType<Player>();
        Platform = GameObject.FindGameObjectWithTag("Platform");
        transform.position = Platform.transform.position;
    }
    public void OnAnimationsEnds()
    {
        Destroy(gameObject);
    }
}
