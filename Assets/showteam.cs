using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showteam : MonoBehaviour
{

    public static string teamtxt = "";
    public Text m_MyText;


    // Update is called once per frame
    void Update()
    {
        m_MyText.text = teamtxt;
    }
}
