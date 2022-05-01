using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventorycontroler : MonoBehaviour
{

    public static string inventorySlot = "";

    public Text m_MyText;


    void Update()
    {
        m_MyText.text = inventorySlot;
    }
}
