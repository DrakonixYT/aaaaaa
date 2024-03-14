using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusorkaPoImPlachet : MonoBehaviour
{
    public GameObject barrier1;
    public GameObject Trash1;
    public GameObject Trash2;
    public GameObject Adder;
    public GameObject Adder2;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "hand")
        {
            Adder.SetActive(true);
            Adder2.SetActive(true);
            Destroy(barrier1);
            Destroy(Trash1);
            Destroy(Trash2);
            
        }
    }
}
