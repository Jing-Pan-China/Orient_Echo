using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class StoneLogic : MonoBehaviour
{
    // Start is called before the first frame update
    
     public string requiredItemName = "Stone";
    void Start()
    {
        Inventory.onItemSelected += TryInteract;
    }
    
    // Update is called once per frame
    void Update()
    {  } 
        
    public void TryInteract(NonParticle selectedItem)
    {
    //     //  NonParticle selectedItem = Inventory.Instance.GetCurrentSelectedItem();

    //     // 2. 判断物品是否正确
    //     if (selectedItem != null && selectedItem.text == requiredItemName)
    //     {
    //          Debug.Log("StoneLogic: 物品正确，开门！");
    //     }

    //     else{
    //         Debug.Log("error");
    //     }
    //    } 

        if (selectedItem != null && selectedItem.text == requiredItemName)
        {
             Debug.Log("StoneLogic: 物品正确，开门！");
        }
        else
        {
            Debug.Log("error");
        }
    }
}

