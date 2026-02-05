using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryItemButton : MonoBehaviour
{
    // Start is called before the first frame update
    
    private NonParticle item;
    private Button button;

    [SerializeField] private TMP_Text text;  


    private void Awake()
    {
        button=GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    public void SetItem(NonParticle newItem)
    {
        item=newItem;
        text.text=item.text;
        gameObject.name=$"ItemSlot_{item.text}";  
    }
    

     private void OnClick()
    {
        Inventory.Instance.SelectItem(item);  
    }
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

