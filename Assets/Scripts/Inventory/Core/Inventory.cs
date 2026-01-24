using System.Collections;
using System.Collections.Generic;
// using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using UnityEngine;

public class Inventory : MonoBehaviour
{   
   
   
    // Inventory Singleton
    public static Inventory Instance{get;private set;}
    public List<NonParticle> nonParticleList= new List<NonParticle>();
    public InventoryUI inventoryUI;
    
    
    private void Awake()
    {
        Instance=this;
    }



    public void AddNonParticle(NonParticle item)
    {   
        
        nonParticleList.Add(item);
       
       
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

