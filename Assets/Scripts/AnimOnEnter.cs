using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimOnEnter : MonoBehaviour
{
    public Animator anim;
    public bool opened = false;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "hand")
        {
            if (opened == true)
            {
                anim.Play("nuh");
                opened = true;
                Invoke("Example", 5);
            }
            else
            {
                anim.Play("p[op'op 0");
                opened = true;
            }
            
            
        }

       



    }
}