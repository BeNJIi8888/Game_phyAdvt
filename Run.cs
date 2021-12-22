using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Horizontal"))
        {
            run();           
        }

        if (Input.GetButtonUp("Horizontal"))
        {
            idle();
        }
    }

    void run()
    {
        animator.SetTrigger("Run");
    }

    void idle()
    {
        animator.SetTrigger("Idle");
    }
}
