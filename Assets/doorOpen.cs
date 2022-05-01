using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class doorOpen : MonoBehaviour
{
    public string itemName;

    Animator animator;
    Collider m_Collider;

    public Text m_MyText;

    private void Start()
    {
        animator = GetComponent<Animator>();
        m_Collider = GetComponent<Collider>();
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
                if (inventorycontroler.inventorySlot == itemName)
                {
                    animator.SetBool("open", true);
                    m_Collider.enabled = !m_Collider.enabled;
                }
                else
                {
                    StartCoroutine(DisplayNeed());
                }
            }
        }

    }

    IEnumerator DisplayNeed()
    {
        m_MyText.text = "You need a " + itemName;
        yield return new WaitForSeconds(2f);
        m_MyText.text = "";
    }
}
