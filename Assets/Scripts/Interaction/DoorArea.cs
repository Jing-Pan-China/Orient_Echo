using UnityEngine;

public class DoorArea : InteractionArea3D
{
    public DoorController doorController;
    public LightControl lightControl;

    private bool isOpen = false;

    protected override void StartInteraction()
    {
        if (!isOpen)
        {
            doorController.DoorOpen();
            isOpen = true;
        }
    }

    protected override void EndInteraction()
    {
        Debug.Log("EndInteraction called, isOpen = " + isOpen);
        if (isOpen)
        {
            Debug.Log("Player left → Close door");

            doorController.DoorClose();
            lightControl.TurnOffLight();

            isOpen = false;
        }



    }
}


















// // using System.Collections;
// // using System.Collections.Generic;
// // using UnityEngine;

// // public class DoorArea : MonoBehaviour
// // {
// //     // Start is called before the first frame update
// //     void Start()
// //     {
        
// //     }

// //     // Update is called once per frame
// //     void Update()
// //     {
        
// //     }
// // }


// using UnityEngine;

// public class DoorArea : InteractionArea3D
// {
//     public DoorController doorController;
    
//     protected override void StartInteraction()
//     {
//         doorController.DoorOpen();
//     }

//     // private void OnTriggerEnter(Collider other)
//     // {
  
        
//     // }

//     // protected override void EndInteraction()
//     // {
//     //     doorController.DoorClose();
//     // }

// }

