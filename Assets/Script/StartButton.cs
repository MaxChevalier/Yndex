using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StartButton : MonoBehaviour
{
    public GameObject button ;
    public static bool isGameStarted = false;
    public static bool isthisclient = false;

    void Start()
    {
        button = this.gameObject;
    }

    void Update()
    {
        if (!isGameStarted)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Input.GetMouseButtonDown(0))
            {
                if (Physics.Raycast(ray,out hit) && hit.collider.gameObject == gameObject)
                {
                    isGameStarted = true;
                    isthisclient = true;
                }
            }
        }
    }
}
