using UnityEngine;
using UnityEngine.XR;

public class QuestSettings : MonoBehaviour
{
    void Start()
    {
        OVRManager.fixedFoveatedRenderingLevel = OVRManager.FixedFoveatedRenderingLevel.Medium;
        OVRManager.useDynamicFixedFoveatedRendering = false;
        //XRSettings.eyeTextureResolutionScale = 1.5f;
        //OVRManager.SetSpaceWarp(true);
        //OVRPlugin.systemDisplayFrequency = 120.0f;
    }
}
