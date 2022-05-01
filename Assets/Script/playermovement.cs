using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class playermovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;

    public Transform groundcheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public float jumpheight = 3f;

    PhotonView view;
    Animator animator;
    Transform transform;

    Vector3 velocity;
    bool isGrounded;

    public bool Disable = false;

    private void Start()
    {
        view = GetComponent<PhotonView>();
        animator = GetComponent<Animator>();
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundcheck.position, groundDistance, groundMask);
        StartCoroutine("animationtest");

        if (view.IsMine && !Disable)
        {
            if (isGrounded && velocity.y < 0)
            {
                velocity.y = -2f;
            }
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");
            if (x==0 && z == 0)
            {
                animator.SetBool("iswalking", false);
            }
            else
            {
                animator.SetBool("iswalking", true);
            }

            Vector3 move = transform.right * x + transform.forward * z;
            controller.Move(move * speed * Time.deltaTime);

            if (Input.GetButtonDown("Jump") && isGrounded)
            {
                velocity.y = Mathf.Sqrt(jumpheight * -2f * gravity);
            }

            velocity.y += gravity * Time.deltaTime;

            controller.Move(velocity * Time.deltaTime);
        }
    }

    IEnumerator animationtest()
    {
        Vector3 startPos = transform.position;
        yield return new WaitForSeconds(0.1f);
        Vector3 finalPos = transform.position;
        animator.SetBool("isonground", isGrounded);
    }
}
