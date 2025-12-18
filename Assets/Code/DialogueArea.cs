using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueArea : MonoBehaviour
{
    

    // public GameObject target;
    public bool playerInRange=false;

    public DialogueManager dialogueManager;

    
    // dialogueStarted is a flag variable used to record whether the dialogue has been started.”
    private bool dialogueStarted=false;



    // 
    void Update()
    {
        if (playerInRange == true && !dialogueStarted )
        {
            dialogueManager.StartDialogue();
            dialogueStarted=true;
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        // if (other.gameObject == target)
        // {
        //     playerInRange=true;
        
        // }

        // use layer matrix 
        playerInRange=true;
    }

    private void OnTriggerExit2D(Collider2D other){
    //     if(other.gameObject==target)
    // {
    //     playerInRange=false;
    //     dialogueStarted=false;
    // }

        

    // use layer matrix 
    playerInRange=false;
    dialogueStarted=false;
     

    }
    



  
}
