using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checlist : MonoBehaviour
{
    public GameObject turnOn;
    public GameObject turnOff;
    void OnTriggerEnter(Collider other)
    { 
            turnOff.active = false;
            turnOn.active = true;
    }
}
