using UnityEngine;

public class DoorArea : InteractionArea3D
{
    public DoorController doorController;
    public LightControl lightControl;

    public CurtainControl curtainControl;

    private bool isOpen = false;

    //The Curtain need to be open when the scence is started  
    void Start()
    {
        Debug.Log("set curtain open");
        curtainControl.CurtainOpen();
      
    }

    // The environment changes when the player exits the door trigger area with three elements (door,curtain and light)
    void CloseEnvironment()
    {
        doorController.DoorClose();
        curtainControl.CurtainClose();
        lightControl.TurnOffLight();
    }

    // The door is open when the player enter into the door trigger area
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

             CloseEnvironment();
            
            // doorController.DoorClose();
            // curtainControl.CurtainClose();
            // // yield return new WaitForSeconds(0.5f);
            // lightControl.TurnOffLight();

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

