using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DragonBones;

public class PlayerCtrl : MonoBehaviour
{
    public float speed;
    public UnityArmatureComponent anim;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!anim.animation.isPlaying)
        {
            anim.animation.Play("bend", -1);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector2(speed * Time.deltaTime,0));
            anim.animation.GotoAndPlayByFrame("MovingRight", 10);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector2(-speed * Time.deltaTime,0));
            anim.animation.GotoAndPlayByFrame("Movingleft", 10);
        }
    }
}

