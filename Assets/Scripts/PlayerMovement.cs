using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
    public CharacterController2D controller;

    public float horizontalMove = 0f;

    public float runSpeed = 40f;

    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        //Player animation for movement
        if (horizontalMove == 0)
        {
            anim.SetBool("isMoving", false);
        }
        else
        {
            anim.SetBool("isMoving", true);
        }
    }
    // Update is called once per frame
    void Update()
    {
       horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
    }

    void FixedUpdate()
    {
        // Move our character

        controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);
    }

}
