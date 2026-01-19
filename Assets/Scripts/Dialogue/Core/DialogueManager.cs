using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    
    public DialogueNode startNode;
    private DialogueNode currentNode;
    
 
    // dialogueStarted is a flag variable used to record whether the dialogue has been started.”
    
    private bool dialogueStarted=false;

    // Reference to DialogueUI
    public DialogueUI dialogueUI;
    void Start()
    {
    //   dialogueUI=FindObjectOfType<DialogueUI>();
    }
    

  

      public void StartDialogue()
    { 
      
      if (dialogueStarted) return;
      else{
       dialogueStarted= true;
       currentNode =startNode;
      
       ShowCurrentNode(); 
      }
    }


    //linearity by pressing next 
    public void Next()

    {
        // Guard Clause
        if(!dialogueStarted||currentNode==null) return;
        if(currentNode.nextNode==null)
        {
            
            dialogueStarted=true;
            dialogueUI.HideDialogue();
            return;

        }
        
        
        //  Linear node or branch node: move to the next dialogue node
        else if(currentNode.nextNode!=null ||currentNode.nextNodes.Length>1)
        {
            currentNode= currentNode.nextNode;
            ShowCurrentNode();
        }
        
      
      
        
      
    } 


    //unlinearity by selecting the choices
    public void SelectChoice(int index)
    {
        currentNode=currentNode.nextNodes[index];
        ShowCurrentNode();
    }





    public void ShowCurrentNode()
    {   
        //  Linear node:display text;
        Debug.Log(currentNode.text);
        dialogueUI.ShowDialogueText(currentNode.text);
        
        
        // Branches：display choiceTexts;
        if (currentNode.choiceTexts != null && currentNode.choiceTexts.Length > 0)
    {
        dialogueUI.ShowChoiceTexts(currentNode.choiceTexts);
        dialogueUI.SetNextButtonVisible(false);
        Debug.Log(currentNode.choiceTexts.Length);
    }
        
        else
        {
            dialogueUI.HideChoices();
            dialogueUI.SetNextButtonVisible(true);
        }
       
    }


 
    // stop the current dialogue when the player leaves the inRange area;
    public void CancelDialogue()
    {
        dialogueStarted=false; 
        currentNode=null;
        if (dialogueUI != null && dialogueUI.gameObject != null)
       {
        dialogueUI.HideDialogue();
       }
    }

    void Update()
    {
        if(currentNode!=null&&Input.GetKeyDown(KeyCode.E))
        {
            Next();
        }

        
    }
}


