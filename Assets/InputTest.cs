using UnityEngine;
using UnityEngine.InputSystem;
public class InputTest : MonoBehaviour
{
    public InputActionProperty moveAction;
    public InputActionProperty jumpAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float value = moveAction.action.ReadValue<float>();
        Debug.Log("Move Action Value: " + value);

        bool jumpValue = jumpAction.action.IsPressed();
        Debug.Log("Jump Action Value: " + jumpValue);
    }
}
