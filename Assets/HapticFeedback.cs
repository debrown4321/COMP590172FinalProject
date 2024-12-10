using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HapticFeedback : MonoBehaviour
{
    private InputDevice controller;

    void Start()
    {
        // Right hand
        controller = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
    }

    public void TriggerHaptic(float amplitude, float duration)
    {
        if (controller.isValid)
        {
            controller.SendHapticImpulse(0, amplitude, duration);
        }
        else
        {
            Debug.LogWarning("Haptic controller not found!");
        }
    }
    //EXAMPLE USAGE: hapticFeedback.TriggerHaptic(0.8f, 0.5f)
}
