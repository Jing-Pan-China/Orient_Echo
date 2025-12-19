using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    // Start is called before the first frame update
    public DialogueNode startNode;
    private DialogueNode currentNode;

    private bool dialogueStarted=false;
    void Start()
    {
      
    }
    

    //  public void StartDialogue()
    // {
    //    currentNode =startNode;
    //    ShowCurrentNode(); 
    // }

      public void StartDialogue()
    {  
      if (!dialogueStarted)
      {
       currentNode =startNode;
       ShowCurrentNode(); 
      }
    }

    public void Next()
    {
        if(currentNode.nextNode==null)
        {
            // Debug.Log("....");
            dialogueStarted=true;
            return;

        }

        currentNode= currentNode.nextNode;
        ShowCurrentNode();
    }

    // Update is called once per frame
    void ShowCurrentNode()
    {
        Debug.Log(currentNode.text) ;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Next();
        }
    }
}
