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
    public Color darkAmbientColor = new Color(0f, 0f, 0f);   
    public Color normalAmbientColor = new Color(1f, 1f, 1f);  

    private Light directionalLight;
    private bool isLightDimmed = false;  

    void Start()
    {
        // get directionalLight
        directionalLight = GameObject.Find("Directional Light").GetComponent<Light>();
        //RenderSettings.ambientLight = normalAmbientColor;
        Debug.Log("Initial Ambient Light: " + RenderSettings.ambientLight);
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.U))
        {
            Debug.Log("U Key Pressed");
            ToggleAmbientLight();
        }
    }

    void ToggleAmbientLight()
    {
        
        if (isLightDimmed)
        {
            RenderSettings.ambientLight = normalAmbientColor;  
            Debug.Log("Ambient Light: Normal");
        }
        else
        {
            RenderSettings.ambientLight = darkAmbientColor;  
            RenderSettings.reflectionIntensity = 0f;
            RenderSettings.skybox = null;
            directionalLight.enabled = false; 
            Debug.Log("Ambient Light: Dark");
        }

       
        isLightDimmed = !isLightDimmed;
    }
}