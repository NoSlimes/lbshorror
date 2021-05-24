using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{
    Light pointlight;
    AudioSource buzzing;
    public bool isOn;
  
    void Start()
    {
        pointlight = GetComponentInChildren<Light>();
        buzzing = GetComponentInChildren<AudioSource>();
        pointlight.enabled = isOn;
        buzzing.enabled = isOn;
    }

    public void LightOnOff()
    {
        isOn = !isOn;
        pointlight.enabled = isOn;
        buzzing.enabled = isOn;
    }
}
