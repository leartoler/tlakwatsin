using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DragonBones;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    float dashMove = 0;
    bool jump = false;
  
   

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

    void Dash()
    {
        dashMove = horizontalMove * 2;
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                
            }
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


