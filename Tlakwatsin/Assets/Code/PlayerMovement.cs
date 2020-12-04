﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DragonBones;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    public float runSpeed = 40f;
    float horizontalMove = 0f;       
    bool jump = false;




    // Update is called once per frame
    void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);


        }

        else
        {
            return;
        }
    }

        public void OnLanding()
        {
            animator.SetBool("IsJumping", false);
        }

        
	
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        
        jump = false;

    }
}

