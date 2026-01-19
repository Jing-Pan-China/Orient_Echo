using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    
    
    // Start is called before the first frame update

    public Transform inventoryPanel; 
    public GameObject itemSlotPrefab; 

    public void Refresh(List<NonParticle> items)
    {
        Debug.Log("Refresh 函数被调用了！"); 
        // 1. 清空旧 UI
        foreach (Transform child in inventoryPanel)
        {
            Destroy(child.gameObject);
        }

        // 2. 重新生成
        foreach (NonParticle item in items)
        {
            GameObject slot = Instantiate(itemSlotPrefab, inventoryPanel);


            TMP_Text text = slot.GetComponentInChildren<TMP_Text>();
            text.text = item.text;
            slot.name = $"ItemSlot_{item.text}";
        }
        
        Debug.Log("Refresh 被调用了！物品数量: " + items.Count);
        
    }

   
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
