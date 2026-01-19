using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI; 

public class DialogueUI : MonoBehaviour
{

    public GameObject dialoguePanel;
    public Text dialogueText;
    
    public Button nextButton;

    public Text[] choiceTexts; 
    // Start is called before the first frame update
    void Start()
    {
        
        dialoguePanel.SetActive(false);

    }
    
    public void ShowDialogueText(string text)
    {   
    
    

        dialoguePanel.SetActive(true);
        dialogueText.text=text;
        


    }

    public void ShowChoiceTexts(string[] choices)

    {
        dialoguePanel.SetActive(true);
        for (int i = 0; i < choiceTexts.Length; i++)
    {
        if (i < choices.Length)
        {
            choiceTexts[i].gameObject.SetActive(true);
            choiceTexts[i].text = choices[i];
            Debug.Log(choices[i]);
        }
        else
        {
            choiceTexts[i].gameObject.SetActive(false);
        }
    }
    }


    

    public void HideDialogue()
    {   
        
        dialoguePanel.SetActive(false);
    }

    

   public void HideChoices()
    {
        for (int i = 0; i < choiceTexts.Length; i++)
        {
            choiceTexts[i].gameObject.SetActive(false);
        }
    }

   public void SetNextButtonVisible(bool visible)
    {
        nextButton.gameObject.SetActive(visible);
    }


    void Update()
    {
        
    }
}
