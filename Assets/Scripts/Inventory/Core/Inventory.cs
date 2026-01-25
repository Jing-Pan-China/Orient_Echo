using System.Collections;
using System.Collections.Generic;
// using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using  System;

using UnityEngine;

public class Inventory : MonoBehaviour
{   
   
   
    // Inventory Singleton
    public static Inventory Instance{get;private set;}
    public List<NonParticle> nonParticleList= new List<NonParticle>();

    public static event Action onNonParticleAdded;
    // public static event Action<NonParticle> onNonParticleAdded;
    public InventoryUI inventoryUI;
    
    
    private void Awake()
    {
        Instance=this;
    }



    public void AddNonParticle(NonParticle item)
    {   
        
        nonParticleList.Add(item);
        // 1. Inventory logic and its UI are not seperated
        // inventoryUI.Refresh(nonParticleList);
        // inventoryUI.gameObject.SetActive(true);
       
        // 2.Observation pattern
        // onNonParticleAdded?.Invoke(item);
        onNonParticleAdded?.Invoke();
        
    }
     void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

