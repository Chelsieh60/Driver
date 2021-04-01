using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableLights : MonoBehaviour
{
    // Start is called before the first frame update
    Light light;

    void Start()
    {
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            
            light.enabled = !light.enabled;
        }
    }
}
