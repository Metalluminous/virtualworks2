using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class juttu1 : MonoBehaviour
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
            light.color = Color.white;
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
