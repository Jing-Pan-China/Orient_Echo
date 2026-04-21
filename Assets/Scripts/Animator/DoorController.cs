using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Animator animator;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetTrigger("OpenDoor");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            animator.SetTrigger("CloseDoor");
        }
    }
}