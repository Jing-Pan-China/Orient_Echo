using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class Pickup : MonoBehaviour
{    

   public NonParticle nonParticle;
    // Start is called before the first frame update
   private void Start()
{
    Debug.Log("The Card is：" + nonParticle.text);
}

   public void OnMouseDown()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        Inventory inventory = player.GetComponent<Inventory>();
        inventory.nonParticleList.Add(nonParticle);

        int count = inventory.nonParticleList.Count;
        Debug.Log("the inventory has" + count );
        
        foreach (var item in inventory.nonParticleList)
        {
             Debug.Log(item.text); 
        }
        Destroy(gameObject);

}


     
    
    // Update is called once per frame
    void Update()
    {
        
    }

    

}
