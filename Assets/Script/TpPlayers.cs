using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class TpPlayers : MonoBehaviour
{
    public float centerX;
    public float centerZ;
    public float R;
    public Transform player;

    private bool Initalise = false;

    public playermovement playermovement;

    void Update()
    {
        if (StartButton.isGameStarted && !Initalise)
        {
            Initalise = true;
            StartCoroutine("Teleport");
        }
    }

    IEnumerator Teleport()
    {
        playermovement.Disable = true;
        yield return new WaitForSeconds(0.01f);
        player.position = new Vector3(Random.Range(centerX - R, centerX + R), 0f, Random.Range(centerZ - R, centerZ + R));
        yield return new WaitForSeconds(0.01f);
        playermovement.Disable = false;
    }
}
