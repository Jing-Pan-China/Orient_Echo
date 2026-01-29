  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// public abstract class InteractionArea:MonoBehaviour
// {
    
//     public bool playerInRange=false;
//     public GameObject eHint;


//     void Start()
//     {
//         eHint.SetActive(false);
//     }

    
//     void Update()
//     {
        
        
//         if (playerInRange==true && Input.GetKeyDown(KeyCode.E))

//         {
//             eHint.SetActive(false);
//             OnInteract();
           
//         }
//     }


//     protected abstract void OnInteract();

//     private void OnTriggerEnter2D(Collider2D other)
//     {
      

//         // use layer matrix 
//         playerInRange=true;
//         eHint.SetActive(true);
//     }

//     private void OnTriggerExit2D(Collider2D other)
//     {
//    // use layer matrix 
//     playerInRange=false;
//     eHint.SetActive(false);
//     UnInteract();
    
//     }

//     protected abstract void UnInteract();


// }



public class DialogueArea: InteractionArea
{
    public DialogueManager dialogueManager;
    protected override void StartInteraction()
    {
        dialogueManager.StartDialogue();

    }

    protected override void EndInteraction()
    {
        dialogueManager.CancelDialogue();
    }
}





























// public class DialogueArea : MonoBehaviour
// {
    

//     // public GameObject target;
//     public bool playerInRange=false;

//     public DialogueManager dialogueManager;

//     // E dialogue hint 
//     public GameObject eHint;

    
 

//     void Start()
//     {
//         eHint.SetActive(false);
//     }
     
//     // 
//     void Update()
//     {
        
        
//         if (playerInRange==true && Input.GetKeyDown(KeyCode.E))

//         {
//             eHint.SetActive(false);
//             dialogueManager.StartDialogue();
           
//         }
//     }


//     private void OnTriggerEnter2D(Collider2D other)
//     {
      

//         // use layer matrix 
//         playerInRange=true;
//         eHint.SetActive(true);
//     }

//     private void OnTriggerExit2D(Collider2D other){
//     //     if(other.gameObject==target)
//     // {
//     //     playerInRange=false;
//     //     dialogueStarted=false;
//     // }

        

//     // use layer matrix 
//     playerInRange=false;
//     eHint.SetActive(false);
//     dialogueManager.CancelDialogue();
    
     

//     }
    



  
// }
