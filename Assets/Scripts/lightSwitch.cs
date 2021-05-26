using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightSwitch : MonoBehaviour
{
    public bool isOn;
    public Light[] lamps;
    void Start()
    {
        foreach (var lamp in lamps)
        {
            lamp.enabled = isOn;
        }
    }

    public void onOff()
    {
        isOn = !isOn;
        foreach (var lamp in lamps)
        {
            lamp.enabled = isOn;
        }
    }
    
    
}
