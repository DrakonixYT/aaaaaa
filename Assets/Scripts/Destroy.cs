using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject Pomoi;
    public GameObject dermo;
    public GameObject Addd;
    public GameObject Particles;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sosat")

        {
            Particles.SetActive(true);
            Addd.SetActive(true);
            Destroy(Pomoi);
            Destroy(dermo);
        }
    }
}
