using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{

    public GameObject playerPrefab;

    public float centerX;
    public float centerZ;
    public float R;

    private bool allreadyAlfa;


    private void Start()
    {
        Vector3 randomPosition = new Vector3(Random.Range(centerX - R, centerX + R), 0f, Random.Range(centerZ - R, centerZ + R));
        PhotonNetwork.Instantiate(playerPrefab.name, randomPosition, Quaternion.identity);


    }


}
