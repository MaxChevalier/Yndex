using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class CreateAndJoiningRooms : MonoBehaviourPunCallbacks
{
    public InputField createInput;
    public InputField joinInput;
    public GameObject lobbyPannel;
    public GameObject roomPannel;
    public Text roomName;

    private bool start = false;

    private void Start()
    {
        PhotonNetwork.JoinLobby();
    }

    public void CreateRoom()
    {
        if (createInput.text.Length >= 1)
        {
            PhotonNetwork.CreateRoom(createInput.text, new RoomOptions() { MaxPlayers = 10 });
        }
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinInput.text);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.LoadLevel("Lobby");
    }
    /*lobbyPannel.SetActive(false);
    roomPannel.SetActive(true);
    roomName.text = "Room Name: " + PhotonNetwork.CurrentRoom.Name;
}

public void OnClickLeaveRoom()
{
    PhotonNetwork.LeaveRoom();
}

public override void OnLeftRoom()
{
    roomPannel.SetActive(false);
    lobbyPannel.SetActive(true);
}

public override void OnConnectedToMaster()
{
    PhotonNetwork.JoinLobby();
}



public void OnClickStart()
{
    start = true;
}

void Update()
{
    if (start)
    {
        PhotonNetwork.LoadLevel("Game");
    }
}*/
}
