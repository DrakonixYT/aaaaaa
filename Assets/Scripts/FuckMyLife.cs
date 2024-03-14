using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuckMyLife : MonoBehaviour
{
    public GameObject delete;
    public GameObject delete1;
    public GameObject add1;
    public GameObject add2;
    public GameObject add3;
    private void OnTriggerEnter(Collider other)
    {
        delete.SetActive(false);
        delete1.SetActive(false);
        add1.SetActive(true);
        add2.SetActive(true);
        add3.SetActive(true);
    }
}
