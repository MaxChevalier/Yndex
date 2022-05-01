using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Photon.Pun;

public class pickupItem : MonoBehaviourPun
{

    public string itemName;

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
                inventorycontroler.inventorySlot = itemName;
                Debug.Log(itemName);
            }
        }

    }
}
