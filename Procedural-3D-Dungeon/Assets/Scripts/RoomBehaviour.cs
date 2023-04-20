using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomBehaviour : MonoBehaviour
{
    // 0 - up
    // 1 - Down
    // 0 - Right
    // 0 - Left
    public GameObject[] walls;
    public GameObject[] doors;
   // public bool[] testStatus;

    // Start is called before the first frame update
    //void Start()
    //{
    //   UpdateRoom(testStatus);
    //}

   public void UpdateRoom(bool[] status)
    {
        for (int i = 0; i < status.Length; i++)
        {
            doors[i].SetActive(status[i]);
            walls[i].SetActive(!status[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
