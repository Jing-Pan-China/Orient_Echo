using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// public class InteractionArea : MonoBehaviour
// {
//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }
// }



public abstract class InteractionArea:MonoBehaviour
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
            OnInteract();
           
        }
    }


    protected abstract void OnInteract();

    private void OnTriggerEnter2D(Collider2D other)
    {
      

        // use layer matrix 
        playerInRange=true;
        eHint.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
   // use layer matrix 
    playerInRange=false;
    eHint.SetActive(false);
    UnInteract();
    
    }

    protected abstract void UnInteract();


}
