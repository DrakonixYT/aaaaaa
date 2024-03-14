using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class ass : MonoBehaviour
{
    public GameObject light;
    public bool on = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "hand")
  
        {
            if (on == false)
            {
                light.SetActive(true);
                on = true;
            }
            else
            {
                light.SetActive(false);
                on = false;
            }
        }
    }
        
        
}
