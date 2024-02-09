using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class juttu : MonoBehaviour
{
    // Start is called before the first frame update
    public InputActionReference action;
    public Light light;
    void Start()
    {
        Light light = GetComponent<Light>();
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            light.color = Color.green;
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
