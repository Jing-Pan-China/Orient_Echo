using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

using UnityEngine;

using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Animator animator;

    // void Update()
    // {
    //     if (Input.GetKeyDown(KeyCode.E))
    //     {
    //         //animator.SetTrigger("OpenDoor");
    //         Debug.Log("press E");
    //         animator.SetBool("OpenDoor", true);
    //         animator.SetBool("CloseDoor", false);
    //     }

    //     if (Input.GetKeyDown(KeyCode.R))
    //     {
    //         //animator.SetTrigger("CloseDoor");
    //         animator.SetBool("OpenDoor", false);
    //         animator.SetBool("CloseDoor", true);
    //     }
    // }

    public void DoorOpen()
    {
        // if (Input.GetKeyDown(KeyCode.E))
        // {
            //animator.SetTrigger("OpenDoor");
            Debug.Log("press E");
            animator.SetBool("OpenDoor", true);
            animator.SetBool("CloseDoor", false);
        // }
    }

    public void DoorClose()
    {
         
         animator.SetBool("OpenDoor", false);
         animator.SetBool("CloseDoor", true);
         Debug.Log("CloseDoor called");
    }
}