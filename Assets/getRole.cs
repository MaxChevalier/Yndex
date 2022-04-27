using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class getStartRole : MonoBehaviour
{
    public infection playerinfection;


    private bool Initalise = false;

    // Update is called once per frame
    void Update()
    {
        if (StartButton.isGameStarted && !Initalise)
        {
            Initalise = true;
            BecomeImposter(chose_impostor.whichPlayerIsImposter);
        }
    }

    public void BecomeImposter(int ImposterNumber)
    {
        if (PhotonNetwork.LocalPlayer == PhotonNetwork.PlayerList[ImposterNumber])
        {
            playerinfection.team = "alfa";
        }
    }
}
