using System.Collections;
using System.Collections.Generic;
// using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using UnityEngine;

public class Inventory : MonoBehaviour
{   
    public List<NonParticle> nonParticleList= new List<NonParticle>();
    public InventoryUI inventoryUI;
    
    // Start is called before the first frame update

    public void AddNonParticle(NonParticle item)
    {   
        
        nonParticleList.Add(item);
        Debug.Log("inventoryUI 的值是");
       
        inventoryUI.Refresh(nonParticleList);
        inventoryUI.gameObject.SetActive(true);
       
    }
     void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

