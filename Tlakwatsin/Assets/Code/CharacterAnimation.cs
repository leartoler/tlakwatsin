using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DragonBones;

public class CharacterAnimation : MonoBehaviour
{
    public string idleAnimation = "Idle";
    public string walkAnimation = "Walk";
    public string jumpAnimation = "Jump";

    enum State {IDLE, WALKING, JUMPING};
    private State state = State.IDLE;

    private UnityArmatureComponent armatureComponent;
    private DragonBones.AnimationState aimState = null;


    // Use this for initialization
    void Start ()
    {
        armatureComponent = transform.GetComponentInChildren<UnityArmatureComponent>();
    }
	
	// Update is called once per frame
	/*void Update ()
    {
        if (state != State.AIMING && aimState != null && aimState.weight > 0)
        {
            aimState.weight = Mathf.Lerp(aimState.weight, 0, 0.2f);
        }
    }*/

    public void Idle()
    {
        
            armatureComponent.animation.FadeIn(idleAnimation, 0.5f, -1);
            armatureComponent.animation.timeScale = 1f;
            state = State.IDLE;
        }
    
    //-------------------------------------------

    public void Walk(float speed)
    {
        
            if (speed > 0 && transform.lossyScale.x > 0 || speed < 0 && transform.lossyScale.x < 0)
            {
                if (state != State.WALKING)
                {
                    armatureComponent.animation.FadeIn(walkAnimation, 0.25f, -1);
                    state = State.WALKING;
                }
                armatureComponent.animation.timeScale = speed;
            }
            else if (speed < 0 && transform.lossyScale.x > 0 || speed > 0 && transform.lossyScale.x < 0)
            {
                if (state != State.WALKING)
                {
                    armatureComponent.animation.FadeIn(walkAnimation, 0.25f, -1);
                    state = State.WALKING;
                }
                armatureComponent.animation.timeScale = -speed;
            }
        }
    

    public void Jump()
    {
        
            armatureComponent.animation.FadeIn(jumpAnimation, 0.25f, 1);
            armatureComponent.animation.timeScale = 1f;
            state = State.JUMPING;
        }
    }








