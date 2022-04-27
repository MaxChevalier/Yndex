using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class AU_PlayerController : MonoBehaviour
{
    public infection playerinfection;
    public int test = 10;

    private bool Initalise = false;

    PhotonView view;

    private void Start()
    {
        view = GetComponent<PhotonView>();
    }

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
        if (view.Owner == PhotonNetwork.PlayerList[ImposterNumber])
        {
            playerinfection.team = "alfa";
        }
    }
}
