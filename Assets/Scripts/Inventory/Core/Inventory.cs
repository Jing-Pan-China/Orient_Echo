using System.Collections;
using System.Collections.Generic;
// using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using  System;

using UnityEngine;
// using System.Security.Cryptography.X509Certificates;
// using System.Diagnostics.Contracts;
// using System.Security.Cryptography;

// using System.Reflection.Metadata.Ecma335;

public class Inventory : MonoBehaviour
{   
   
   
    // Inventory Singleton
    public static Inventory Instance{get;private set;}
    public List<NonParticle> nonParticleList= new List<NonParticle>();
    // events
    public static event Action onNonParticleAdded;
    public static event Action<NonParticle> onItemSelected;
    // public static event Action<NonParticle> onNonParticleAdded;
    public InventoryUI inventoryUI;

    private NonParticle _currentSelectedItem;

    
    
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


    public void SelectItem(NonParticle item)
    {   _currentSelectedItem = item;
        onItemSelected?.Invoke(item);
      
    }


    public 
     void Start()
    { }
    
    public NonParticle GetCurrentSelectedItem()
    {
        return _currentSelectedItem;
    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}

