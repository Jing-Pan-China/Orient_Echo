using UnityEngine;

public class CurtainArea : InteractionArea3D
{
  

    public CurtainControl curtainControl;
    public LightControl lightControl;

    private bool isOpen = true;

    void Awake()
{
    Debug.Log("CurtainArea Awake");
}
    
    
    // void Start()
    // {
    //   Debug.Log("be in curtain range");
      
    // }

    protected override void StartInteraction()
    {
        if (isOpen)
        {
           Debug.Log("be in curtain range");
           curtainControl.CurtainOpen();
           Debug.Log("OpenCurtain called");
           lightControl.TurnOnLight();
           isOpen =false;
        }
    }

    protected override void EndInteraction()
    {
        Debug.Log("EndInteraction called, isOpen = " + isOpen);
        // if (isOpen)
        // {
        //     Debug.Log("Player left → Close door");

            
            
        //     doorController.DoorClose();
        //     curtainControl.CurtainClose();
        //     // yield return new WaitForSeconds(0.5f);
        //     lightControl.TurnOffLight();

        //     isOpen = false;
        // }



    }
}
