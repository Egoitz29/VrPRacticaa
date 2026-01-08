using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    public InputActionProperty triggerValue;
    public InputActionProperty GripValue;

    public Animator handAnimator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggerFloat = triggerValue.action.ReadValue<float>();
        float gripFloat = GripValue.action.ReadValue<float>();

        handAnimator.SetFloat("Trigger", triggerFloat);
        handAnimator.SetFloat("Grip", gripFloat);
    }
}
