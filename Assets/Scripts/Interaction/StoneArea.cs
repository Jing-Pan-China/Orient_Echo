using System.Collections;
using System.Collections.Generic;
// using System.Diagnostics;
using UnityEngine;

public class StoneArea : InteractionArea
{
    // Start is called before the first frame update
    void Start()
    {
        //  Inventory.onItemSelected += OnItemSeleted;
        
    }

    

     protected override void OnInteract()

    {
        Debug.Log("interact with stone");
        InventoryUI.Instance.gameObject.SetActive(true);
        

    }

    protected override void UnInteract()
    {
        
    }

 
}
