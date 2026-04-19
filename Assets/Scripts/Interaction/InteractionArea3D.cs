using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public abstract class InteractionArea3D:MonoBehaviour
{
    
    public bool playerInRange=false;
    public GameObject eHint;


    void Start()
    {
        eHint.SetActive(false);
    }

    
    void Update()
    {
        
        
        if (playerInRange==true && Input.GetKeyDown(KeyCode.E))

        {
            eHint.SetActive(false);
            StartInteraction();
           
        }
    }


    protected abstract void StartInteraction();

    private void OnTriggerEnter(Collider other)
    {
      

        // use layer matrix 
        playerInRange=true;
        Debug.Log("TRIGGER ENTER: " + other.name);
        Debug.Log("be in");
        eHint.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
   // use layer matrix 
    playerInRange=false;
    eHint.SetActive(false);
    EndInteraction();
    
    }

    protected virtual void EndInteraction()
    {
        
    }


}
