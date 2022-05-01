using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class chose_impostor : MonoBehaviourPun
{
    public AU_PlayerController PlayerControllers;
    private bool Initalise = false;
    private int rdmImposter;

    public static int whichPlayerIsImposter;

    void Update()
    {
        if (StartButton.isGameStarted && StartButton.isthisclient && !Initalise)
        {
            Initalise = true;
            PickImposter();
        }
    }

    [PunRPC]
    void RPC_SyncImposter(int playerNumber)
    {
        ChangeImpos(playerNumber);
    }

    public void ChangeImpos(int playerNumber)
    {
        chose_impostor.whichPlayerIsImposter = playerNumber;
        StartButton.isGameStarted = true;
    }



    public void PickImposter()
    {
        rdmImposter = Random.Range(0, PhotonNetwork.CurrentRoom.PlayerCount);
        this.photonView.RPC("RPC_SyncImposter", RpcTarget.All, rdmImposter);
    }

    
}
