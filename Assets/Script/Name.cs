using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class Name : MonoBehaviourPunCallbacks
{
    public Text nametext;
    public Text nbtplayertext;
    public Text timertext;

    private int playerCount;
    private int roomSize;
    [SerializeField]
    private int minPlayerToStart;

    void Start()
    {
        if (!photonView.IsMine)
        {
            nametext.text = photonView.Owner.NickName;
        }
    }

}

/*https://www.youtube.com/watch?v=vMOHaB2Fqrg */
