using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collapsed : MonoBehaviour
{
    public void OnAnimationsEnds()
    {
        Destroy(gameObject);
    }
}
