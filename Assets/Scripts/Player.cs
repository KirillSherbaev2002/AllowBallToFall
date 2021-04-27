using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public float RotationSpeed;

    public GameObject Platform;

    public GameObject Collapsed;

    public int TotalCount;
    public TMP_Text TotalText;

    void Start()
    {
        TotalCount = PlayerPrefs.GetInt("Num");
        TotalText.text = TotalCount.ToString();
    }
    void Update()
    {
        if (Ball.OnPlay)
        {
            transform.Rotate(0, -(Input.GetAxis("Mouse X") * RotationSpeed * Time.deltaTime), 0, Space.World);
        }
    }

    public void Touched()
    {
        Instantiate(Collapsed, Platform.transform.position, transform.rotation = Quaternion.Euler(0, 0, 0));
        TotalCount++;
        TotalText.text = TotalCount.ToString();
        PlayerPrefs.SetInt("Num", TotalCount);
        Destroy(Platform);
        Instantiate(Platform, new Vector3(Platform.transform.position.x, Platform.transform.position.y + Random.Range(-10, -30), 
            Platform.transform.position.z),
            Quaternion.Euler(-90, transform.rotation.y + Random.Range(-180, 180), transform.rotation.z));
    }
}
