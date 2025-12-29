using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueArea : MonoBehaviour
{
    

    // public GameObject target;
    public bool playerInRange=false;

    public DialogueManager dialogueManager;

    // E dialogue hint 
    public GameObject eHint;

    
 

    void Start()
    {
        eHint.SetActive(false);
    }
     
    // 
    void Update()
    {
        
        
        if (playerInRange==true && Input.GetKeyDown(KeyCode.E))

        {
            eHint.SetActive(false);
            dialogueManager.StartDialogue();
           
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
      

        // use layer matrix 
        playerInRange=true;
        eHint.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D other){
    //     if(other.gameObject==target)
    // {
    //     playerInRange=false;
    //     dialogueStarted=false;
    // }

        

    // use layer matrix 
    playerInRange=false;
    eHint.SetActive(false);
    dialogueManager.CancelDialogue();
    
     

    }
    



  
}
