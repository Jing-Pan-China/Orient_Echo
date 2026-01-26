using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    // InventoryUI as singleton
    // public static InventoryUI Instance { get; private set; }
    

    
    public static InventoryUI Instance { get; private set; }
    public Transform inventoryPanel; 
    public GameObject itemSlotPrefab; 
    


     private void Awake()
    {
        Instance=this;
      

        
       
        // Inventory.onNonParticleAdded += onNonParticleAdded;
        
    }
    



    void Start()
    {   gameObject.SetActive(false);
        // Inventory.Instance.onNonParticleAdded += onNonParticleAdded;
         // Subscriber
        Inventory.onNonParticleAdded += onNonParticleAdded;
    }

    private void onNonParticleAdded()
    {
        
        Refresh(Inventory.Instance.nonParticleList);
        // gameObject.SetActive(true);
        inventoryPanel.gameObject.SetActive(true);
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




            Button btn = slot.GetComponent<Button>(); 
            NonParticle capturedItem = item;

            btn.onClick.AddListener(() => {
                    
                   
                    Inventory.Instance.SelectItem(capturedItem); 
                    
                    Debug.Log($"点击了 Slot: {capturedItem.text}");
                });
        
        }
        
    }


    

   
    

    // Update is called once per frame
    void Update()
    {
       
    }
}
