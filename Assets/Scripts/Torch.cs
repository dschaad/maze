using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Torch : MonoBehaviour
{
    public Light2D light2d;
    // Start is called before the first frame update
    void Start()
    {
        light2d.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D()
    {
        light2d.enabled = true;
    }
}
