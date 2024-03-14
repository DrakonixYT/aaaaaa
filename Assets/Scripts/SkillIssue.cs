using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillIssue : MonoBehaviour
{
    public GameObject[] Particles;
    public Animator Door1, Door2, Door3, Door4;
    public GameObject opened1;
    public GameObject opened2;
    public GameObject closed1;
    public GameObject closed2;
    public GameObject text1;
    public GameObject text2;
    public GameObject delShtori;
    public GameObject delBeshki;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "hand")
        {
            foreach (GameObject particle in Particles)
            {
                particle.SetActive(false);
            }
            opened1.SetActive(false);
            opened2.SetActive(false);  
            closed1.SetActive(true);
            closed2.SetActive(true);
            text1.SetActive(true);
            text2.SetActive(true);
            delShtori.SetActive(false);
            delBeshki.SetActive(false);
            Door1.transform.rotation = Quaternion.Euler(90, 0, 0);
            Door2.transform.rotation = Quaternion.Euler(90, 0, 0);
            Door3.transform.rotation = Quaternion.Euler(90, 0, 0);
            Door4.transform.rotation = Quaternion.Euler(90, 0, 0);
        }

    }
}
