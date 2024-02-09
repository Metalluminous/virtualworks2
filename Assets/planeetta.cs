using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeetta : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float kaannos = 25.0f;
    void Update()
    {
        
        transform.Rotate(0, kaannos * Time.deltaTime, 0, Space.Self );
    }
}
