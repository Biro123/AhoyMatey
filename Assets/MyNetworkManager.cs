using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {


    public void MyStartHost()
    {
        Debug.Log("Starting Host " + Time.timeSinceLevelLoad);
        StartHost();
    }

    public override void OnStartHost()
    {
        Debug.Log("Started Host " + Time.timeSinceLevelLoad);
    }
}
