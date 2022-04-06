using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class AU_PlayerController : MonoBehaviour
{
    public infection playerinfection;
    public int test = 10;

    public void BecomeImposter(int ImposterNumber)
    {
        if (PhotonNetwork.LocalPlayer == PhotonNetwork.PlayerList[ImposterNumber])
        {
            playerinfection.team = "alfa";
        }
    }
}
