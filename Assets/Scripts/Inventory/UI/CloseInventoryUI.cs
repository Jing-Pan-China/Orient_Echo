using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseInventoryUI : MonoBehaviour


{    


    public Button closeButton; 

    void Start()
    {   
        // gameObject.SetActive(false);
        Inventory.onNonParticleAdded += onNonParticleAdded;
    }
    //   private void Awake()
    // {
    // //     Instance=this;
      

        

    //     // Subscriber
    //     Inventory.onNonParticleAdded += onNonParticleAdded;
        
    // }
    private void onNonParticleAdded()
    {
     
        // show closebutton
        closeButton.gameObject.SetActive(true);
      

    }
   public void OnCloseButtonClick()
    {
        InventoryUI.Instance.gameObject.SetActive(false);
        closeButton.gameObject.SetActive(false);

    }

    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
