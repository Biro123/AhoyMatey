﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {


    public void MyStartHost()
    {
        Debug.Log(Time.timeSinceLevelLoad + ": Starting Host");
        StartHost();
    }

    public override void OnStartHost()
    {
        Debug.Log(Time.timeSinceLevelLoad + ": Started Host");
    }

    public override void OnStartClient(NetworkClient MyClient)
    {
        Debug.Log(Time.timeSinceLevelLoad + ": Client Start Requested");
        InvokeRepeating("PrintDots", 1f, 1f);
        //base.OnStartClient(MyClient);
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        Debug.Log(Time.timeSinceLevelLoad + ": Client Connected to: " + conn.address);
        CancelInvoke();
        //base.OnClientConnect(conn);
    }

    void PrintDots()
    {
        Debug.Log(".");
    }

}
