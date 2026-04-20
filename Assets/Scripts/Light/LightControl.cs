//using UnityEngine;

//public class LightControl : MonoBehaviour
//{
//    public Light[] roomLights;  // Array to store all room lights
//    public float darkLightIntensity = 0.1f;  // Light intensity when U key is pressed
//    public float normalLightIntensity = 1f;  // Initial light intensity
//    private bool isLightDimmed = false;  // Checks if the light has been dimmed

//    void Start()
//    {
//        // Initialize all lights to normal intensity
//        foreach (Light light in roomLights)
//        {
//            light.intensity = normalLightIntensity;
//        }
//    }

//    void Update()
//    {
//        // Press U key to dim the lights
//        if (Input.GetKeyDown(KeyCode.U))
//        {
//            ToggleLight();
//        }
//    }

//    void ToggleLight()
//    {
//        // Toggle the intensity of all lights
//        foreach (Light light in roomLights)
//        {
//            if (isLightDimmed)
//            {
//                light.intensity = normalLightIntensity;
//            }
//            else
//            {
//                light.intensity = darkLightIntensity;
//            }
//        }

//        // Toggle light state
//        isLightDimmed = !isLightDimmed;
//    }
//}



using UnityEngine;

public class LightControl : MonoBehaviour
{
    private Color darkAmbientColor = new Color(0f, 0f, 0f);   
    private Color normalAmbientColor = new Color(0.5f, 0.5f, 0.5f);  

    private Light directionalLight;


    private bool isLightOn=true;

    void Start()
    {
        // get directionalLight
        directionalLight = GameObject.Find("Directional Light").GetComponent<Light>();
        // The light is turned on initailly 
        TurnOnLight();
    }


    public void TurnOnLight()
    {
        if(isLightOn)return;
        Debug.Log("Turn On Light");
        RenderSettings.ambientLight = normalAmbientColor;
        directionalLight.enabled = true;
        directionalLight.intensity = 1f;
        isLightOn=true;
    }


    public void TurnOffLight()
    {
        if(!isLightOn) return;
        Debug.Log("Turn Off Light");
        RenderSettings.ambientLight = darkAmbientColor;
        RenderSettings.reflectionIntensity = 0f;
        directionalLight.enabled = false;
        isLightOn=false;

    }



    // private bool isLightDimed = false;  
     
//     void Start()
//     {
//         // get directionalLight
//         directionalLight = GameObject.Find("Directional Light").GetComponent<Light>();
//         //directionalLight.enabled = false;
//         RenderSettings.ambientLight = normalAmbientColor;
//         Debug.Log("Initial Ambient Light: " + RenderSettings.ambientLight);
//         //Debug.Log("directionalLight: " + directionalLight.c);
//         // LightmapSettings.lightmapsMode = LightmapsMode.NonDirectional;
//         // LightmapSettings.lightmaps = new LightmapData[0];
//     }


// //  

//     void Update()
//     {
        
//         if (Input.GetKeyDown(KeyCode.U))
//         {
//             Debug.Log("U Key Pressed");
//             ToggleAmbientLight();
//         }
//     }
    

//     void ToggleAmbientLight()
//     {
//         Debug.Log("Ambient Light Before First Toggle: " + RenderSettings.ambientLight);
//         if (isLightDimmed)
//         {
//             RenderSettings.ambientLight = normalAmbientColor;
//             directionalLight.enabled = true;
//             directionalLight.intensity = 1f;
//             Debug.Log("Ambient Light: Normal");
//             Debug.Log("Ambient Light after second Toggle: " + RenderSettings.ambientLight);
//         }
//         else
//         {
//             RenderSettings.ambientLight = darkAmbientColor;  
//             RenderSettings.reflectionIntensity = 0f;
//             // RenderSettings.skybox = null;
//             directionalLight.enabled = false; 
//             Debug.Log("Ambient Light: Dark");
//             Debug.Log("Ambient Light after first Toggle: " + RenderSettings.ambientLight);
//         }

       
//         isLightDimmed = !isLightDimmed;
//     }
}




