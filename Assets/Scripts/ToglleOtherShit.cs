using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class ToglleOtherShit : MonoBehaviour
{
    public AudioSource IDK;
    public GameObject OffThisShit0;
    public GameObject OffThisShit1;
    public GameObject OffThisShit2;
    public GameObject OffThisShit3;
    public GameObject OnThisShit0;
    public GameObject OnThisShit1;
    public GameObject OnThisShit2;
    public GameObject OnThisShit3;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "hand") 
        {
            Invoke("Example", 1);
            
        }
    }
    public void Example()
    {
        OnThisShit0.SetActive(true);
        OnThisShit1.SetActive(true);
        OnThisShit2.SetActive(true);
        OffThisShit0.SetActive(false);
        OffThisShit1.SetActive(false);
        OffThisShit2.SetActive(false);
        OffThisShit3.SetActive(false);
        OnThisShit3.SetActive(true);
        IDK.Play();
    }
}
