using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAni : MonoBehaviour
{
    private Animator animator;
    
    public bool isJumping = false;
    public bool isRunning = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Horizontal1")  == true)
        {
            isRunning = true;
            animator.SetBool("isRunning", isRunning);
        }

    }
    void Jump()
    {
        if (Input.GetButtonDown("Jump1") == true)
        {
            isJumping = true;
            animator.SetBool("isJumping", isJumping);
        }
    }
}
