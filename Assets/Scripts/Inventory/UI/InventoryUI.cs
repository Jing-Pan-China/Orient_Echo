using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    
    
    // Start is called before the first frame update

    public Transform inventoryPanel; 
    public GameObject itemSlotPrefab; 

   
    
    private void onNonParticleAdded()
    {
        // Subscriber
        Refresh(Inventory.Instance.nonParticleList);
        gameObject.SetActive(true);
    }


    public void Refresh(List<NonParticle> items)
    {
        
        // 1. clear old UI
        foreach (Transform child in inventoryPanel)
        {
            Destroy(child.gameObject);
        }

        // 2. create the new UI 
        foreach (NonParticle item in items)
        {
            GameObject slot = Instantiate(itemSlotPrefab, inventoryPanel);


            TMP_Text text = slot.GetComponentInChildren<TMP_Text>();
            text.text = item.text;
            slot.name = $"ItemSlot_{item.text}";
        }
        
       
        
    }

   
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
