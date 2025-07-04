using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataLogger : MonoBehaviour
{
    public GMD316PlayerController player;

 

    // Update is called once per frame
    void Update()
    {
        LogPlayerData();

    }
    void LogPlayerData() 
    {
        Debug.Log("Player Position:" + player.transform.position);
        Debug.Log("Player Input:" + Input.GetAxis("Horizontal") + "," + Input.GetAxis("Vertical"));
    }
}
