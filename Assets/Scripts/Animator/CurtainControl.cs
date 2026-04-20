using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurtainControl : MonoBehaviour
{
     public Animator animator;
    public void CurtainOpen()
    {
        // if (Input.GetKeyDown(KeyCode.E))
        // {
            //animator.SetTrigger("OpenDoor");
            // Debug.Log("press E");
            animator.SetBool("OpenCurtain", true);
            animator.SetBool("CloseCurtain", false);
        // }
    }

    public void CurtainClose()
    {
         
         animator.SetBool("OpenCurtain", false);
         animator.SetBool("CloseCurtain", true);
         Debug.Log("CloseCurtain called");
    }
}
