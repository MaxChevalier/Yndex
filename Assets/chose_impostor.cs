using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class chose_impostor : MonoBehaviour
{
    PhotonView myPV;
    public AU_PlayerController PlayerControllers;

    int whichPlayerIsImposter;

    // Start is called before the first frame update
    void Start()
    {
        myPV = GetComponent<PhotonView>();
        Debug.Log(PhotonNetwork.IsMasterClient);
        if (PhotonNetwork.IsMasterClient)
        {
            PickImposter();
        }
    }

    void PickImposter()
    {
        if (myPV.IsMine)
        {
            whichPlayerIsImposter = Random.Range(0, PhotonNetwork.CurrentRoom.PlayerCount);
            myPV.RPC("RPC_SyncImposter", RpcTarget.All, whichPlayerIsImposter);
            Debug.Log("Alfa " + whichPlayerIsImposter);
        }
    }

    [PunRPC]
    void RPC_SyncImposter(int playerNumber)
    {
        whichPlayerIsImposter = playerNumber;
        
        PlayerControllers.BecomeImposter(whichPlayerIsImposter);
    }
}
