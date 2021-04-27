using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public static bool OnPlay = true;

    void Start()
    {
        SetPlay();
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
}