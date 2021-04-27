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
        TotalCount++;
        TotalText.text = TotalCount.ToString();
        PlayerPrefs.SetInt("Num", TotalCount);
        print(TotalCount);
        var LevelV3 = new Vector3(Platform.transform.position.x, Platform.transform.position.y + Random.Range(-4, -10),
            Platform.transform.position.z);
        Instantiate(Platform, LevelV3,
            Quaternion.Euler(0, transform.rotation.y + Random.Range(-180, 180), transform.rotation.z));
        Instantiate(Collapsed);
        print(LevelV3);
        Platform.SetActive(true);
        Destroy(gameObject);
    }
}
