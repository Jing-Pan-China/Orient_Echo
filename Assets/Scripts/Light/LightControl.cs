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
    public Color darkAmbientColor = new Color(0f, 0f, 0f);  // 设置为黑光的颜色
    public Color normalAmbientColor = new Color(1f, 1f, 1f);  // 正常光颜色（白色）
    private bool isLightDimmed = false;  // 检查光源是否变暗

    void Start()
    {
        // 初始化时将环境光设置为正常亮度
        //RenderSettings.ambientLight = normalAmbientColor;
        Debug.Log("Initial Ambient Light: " + RenderSettings.ambientLight);
    }

    void Update()
    {
        // 按下 U 键时切换环境光的状态
        if (Input.GetKeyDown(KeyCode.U))
        {
            Debug.Log("U Key Pressed");
            ToggleAmbientLight();
        }
    }

    void ToggleAmbientLight()
    {
        // 切换环境光颜色
        if (isLightDimmed)
        {
            RenderSettings.ambientLight = normalAmbientColor;  // 恢复正常环境光
            Debug.Log("Ambient Light: Normal");
        }
        else
        {
            RenderSettings.ambientLight = darkAmbientColor;  // 设置为黑光
            Debug.Log("Ambient Light: Dark");
        }

        // 切换状态
        isLightDimmed = !isLightDimmed;
    }
}