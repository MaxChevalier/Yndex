using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infection : MonoBehaviour
{
    public int infectiontime;
    public int PlayerMask;
    public string team;
    private bool infecting = false;
    private bool isInTime = false;
    public GameObject infecparticule;

    void Start()
    {
        infecparticule.SetActive(false);
    }

    void OnTriggerStay(Collider PlayerColid)
    {
        infecting = false;
        if (PlayerColid.gameObject.layer == PlayerMask && team == "surv" && PlayerColid.gameObject.GetComponent<infection>().team == "alfa")
        {
            infecting = true;
        }
    }

    IEnumerator timer()
    {

        while (infectiontime > 0 && infecting)
        {
            infectiontime--;
            yield return new WaitForSeconds(1f);
        }
    }

    void Update()
    {
        if (infecting && !isInTime)
        {
            isInTime = true;
            StartCoroutine(timer());
        }
        else if (!infecting)
        {
            isInTime = false;
        }


        if (infectiontime == 0 && team == "surv")
        {
            team = "inf";
            infecparticule.SetActive(true);
        }
    }
}
