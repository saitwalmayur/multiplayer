using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class MyRoomManager : NetworkRoomManager
{
    // Called when client tries to find a match
    public void FindOrCreateRoom()
    {
        // If server is not running, start host (creates room)
        if (!NetworkServer.active && !NetworkClient.active)
        {
            Debug.Log("No room found → Creating room");
            StartHost();
        }
        else if (NetworkClient.isConnected)
        {
            Debug.Log("Already connected to a room");
        }
        else
        {
            Debug.Log("Joining existing room");
            StartClient();
        }
    }

    public override void OnRoomServerPlayersReady()
    {
        Debug.Log("All players ready → Starting Game");
        ServerChangeScene(GameplayScene);
    }
}
