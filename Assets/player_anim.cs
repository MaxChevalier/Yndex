using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_anim : MonoBehaviour
{

    public Transform R_arm;
    public Transform L_arm;
    public Transform R_led;
    public Transform L_led;

    public void defaultarmposition()
    {
        R_arm.rotation = Quaternion.Euler(0f, 0f, 0f);
        L_arm.rotation = Quaternion.Euler(0f, 0f, 0f);
    }
    public void flyarmposition()
    {
        R_arm.rotation = Quaternion.Euler(0f, 0f, 0f);
        L_arm.rotation = Quaternion.Euler(0f, 0f, 0f);
    }

}
