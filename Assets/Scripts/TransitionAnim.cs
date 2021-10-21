using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionAnim : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            anim.SetBool("isMoving", true);
        }

        else{
            anim.SetBool("isMoving", false);
        }
        if (Input.GetKey("left shift"))
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }
        if (Input.GetKey("t"))
        {
            anim.SetBool("isDancing", true);
        }
        else
        {
            anim.SetBool("isDancing", false);
        }
    }
}
