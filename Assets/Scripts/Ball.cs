using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public static bool OnPlay = true;
    public float MaxSpeed;
    public int score;

    Rigidbody rb;

    void Awake()
    {
        SetPlay();
        rb = GetComponent<Rigidbody>();
    }

    public void SetPause()
    {
        OnPlay = false;
        Time.timeScale = 0f;
    }
    public void SetPlay()
    {
        OnPlay = true;
        Time.timeScale = 1f;
    }
    // Update is called once per frame
    void Update()
    {
        if (Ball.OnPlay)
        {
            if (rb.velocity.magnitude >= 10f)
            {
                rb.velocity = rb.velocity.normalized * MaxSpeed;
            }
        }
    }
}