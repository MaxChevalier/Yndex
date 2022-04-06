using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class mouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;

    PhotonView view;

    float xRotation = 0f;

    public Transform playerBody;

    // Start is called before the first frame update

    void Awake()
    {
        view = GetComponentInParent<PhotonView>();
    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        if (!view.IsMine)
        {
            Destroy(GetComponentInChildren<Camera>().gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            playerBody.Rotate(Vector3.up * mouseX);
    }
}
